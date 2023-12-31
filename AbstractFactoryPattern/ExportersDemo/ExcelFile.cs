using AbstractFactoryPattern.ExportersDemo.Interfaces;

namespace AbstractFactoryPattern.ExportersDemo
{
    public class ExcelFile : IExportedFile
    {
        public void Export(string data)
        {
            Console.WriteLine("Exporting data to Excel file: " + data);
        }
    }
}
