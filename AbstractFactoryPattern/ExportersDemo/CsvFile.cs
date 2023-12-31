using AbstractFactoryPattern.ExportersDemo.Interfaces;

namespace AbstractFactoryPattern.ExportersDemo
{
    public class CsvFile : IExportedFile
    {
        public void Export(string data)
        {
            Console.WriteLine("Exporting data to Csv file: " + data);
        }
    }
}
