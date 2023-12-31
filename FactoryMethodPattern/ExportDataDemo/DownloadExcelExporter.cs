namespace FactoryMethodPattern.ExportDataDemo
{
    public class DownloadExcelExporter : IExporter
    {
        public void Export(string data)
        {
            Console.WriteLine($"Download Excel Exporter: {data}");
        }
    }
}
