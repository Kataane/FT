var root = Combiner.GenerateReport(
    LinksGenerator.Create(), 
    ProductGenerator.Create());

var exporter = new ExcelExporter("Products.xlsx");
exporter.Export(root);

Console.ReadKey();