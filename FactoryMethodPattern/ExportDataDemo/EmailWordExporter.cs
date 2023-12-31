namespace FactoryMethodPattern.ExportDataDemo
{
    public class EmailWordExporter : IExporter
    {
        public void Export(string data)
        {
            Console.WriteLine($"Mail Word Exporter: {data}");
        }
    }
}
