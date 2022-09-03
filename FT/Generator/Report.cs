namespace FT.Generator;

public struct Report
{
    public Report() {}

    public string Name { get; set; } = "";
    public int Quantity { get; set; } = 0;
    public decimal Price { get; set; } = 0;

    public int DeepLevel { get; set; } = 0;

    public IEnumerable<Report>? Next { get; set; } = null;
}