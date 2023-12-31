using AbstractFactoryPattern.ExportersDemo.Interfaces;

namespace AbstractFactoryPattern.ExportersDemo
{
    public class WordFile : IExportedFile
    {
        public void Export(string data)
        {
            Console.WriteLine("Exporting data to Word file: " + data);
        }
    }
}
