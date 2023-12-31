namespace FactoryMethodPattern.ExportDataDemo
{
    public class EmailPDFExporter : IExporter
    {
        public void Export(string data)
        {
            Console.WriteLine($"Mail PDF Exporter: {data}");
        }
    }
}
