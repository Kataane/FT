namespace FT.Exporter;

public interface IExporter
{
    public string Path { get; }

    public void Export(IEnumerable<Report> reports);
}