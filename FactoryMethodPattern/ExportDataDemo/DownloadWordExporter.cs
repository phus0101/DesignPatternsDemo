namespace FactoryMethodPattern.ExportDataDemo
{
    public class DownloadWordExporter : IExporter
    {
        public void Export(string data)
        {
            Console.WriteLine($"Download Word Exporter: {data}");
        }
    }
}
