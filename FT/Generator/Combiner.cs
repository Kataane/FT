namespace FT.Generator;

public static class Combiner
{
    public static IEnumerable<Report> GenerateReport(
        IEnumerable<Link> links,
        IEnumerable<Product> products,
        long rootId = 0,
        int maxDeep = 3) => GenerateReportCore(links, products, rootId, 0, 0, maxDeep);

    private static IEnumerable<Report> GenerateReportCore(
        IEnumerable<Link> links,
        IEnumerable<Product> products,
        long rootId,
        int quantity,
        int deep,
        int maxDeep)
    {
        if (deep == maxDeep) yield break;

        foreach (var link in links.Where(c => EqualityComparer<long>.Default.Equals(c.ParentProduct, rootId)))
        {
            var report = new Report();
            var product = products.FirstOrDefault(p => p.Id == link.Product);

            report.Quantity = link.Quantity - quantity;
            report.Name = product.Name;
            report.Price = product.Price * report.Quantity;
            report.DeepLevel = deep;

            report.Next = GenerateReportCore(
                links, 
                products, 
                link.Product, 
                report.Quantity, 
                deep + 1, 
                maxDeep);

            report.Price += report.Next.DefaultIfEmpty().Sum(r => r.Price);
            yield return report;
        }
    }
}

