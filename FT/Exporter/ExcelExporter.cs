namespace FT.Exporter;

public class ExcelExporter : IExporter
{
    public string Path { get; }

    private readonly XLWorkbook wb;
    private readonly IXLWorksheet ws;

    private int row;

    public ExcelExporter(string path)
    {
        Path = path;

        wb = new XLWorkbook();
        ws = wb.Worksheets.Add("FT");

        ws.Cell("A1").Value = "Изделие";
        ws.Cell("B1").Value = "Кол-во";
        ws.Cell("C1").Value = "Стоимость";

        row = 2;
    }

    public void Export(IEnumerable<Report> reports)
    {
        ExportCore(reports);

        wb.SaveAs("Products.xlsx");
    }

    private void ExportCore(IEnumerable<Report> reports)
    {
        foreach (var report in reports)
        {
            ws.Cell(row, 1).Style.Alignment.SetIndent(report.DeepLevel);

            ws.Cell(row, 1).Value = report.Name;
            ws.Cell(row, 2).Value = report.Quantity;
            ws.Cell(row, 3).Value = report.Price;

            row++;

            ExportCore(report.Next);
        }
    }
}