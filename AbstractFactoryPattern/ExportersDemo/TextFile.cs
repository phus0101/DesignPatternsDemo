using AbstractFactoryPattern.ExportersDemo.Interfaces;

namespace AbstractFactoryPattern.ExportersDemo
{
    public class TextFile : IExportedFile
    {
        public void Export(string data)
        {
            Console.WriteLine("Exporting data to Text file: " + data);
        }
    }
}
