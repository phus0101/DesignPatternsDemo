using AbstractFactoryPattern.ExportersDemo.Interfaces;

namespace AbstractFactoryPattern.ExportersDemo
{
    public class PdfFile : IExportedFile
    {
        public void Export(string data)
        {
            Console.WriteLine("Exporting data to Pdf file: " + data);
        }
    }
}
