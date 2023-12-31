namespace FactoryMethodPattern.ExportDataDemo
{
    public class DownloadPDFExporter : IExporter
    {
        public void Export(string data)
        {
            Console.WriteLine($"Download PDF Exporter: {data}");
        }
    }
}
