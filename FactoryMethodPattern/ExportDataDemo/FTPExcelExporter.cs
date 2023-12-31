namespace FactoryMethodPattern.ExportDataDemo
{
    public class FTPExcelExporter : IExporter
    {
        public void Export(string data)
        {
            Console.WriteLine($"FTP Excel Exporter: {data}");
        }
    }
}
