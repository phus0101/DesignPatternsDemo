using AbstractFactoryPattern.FurnituresDemo.Interfaces;

namespace AbstractFactoryPattern.FurnituresDemo.Victorian
{
    public class TableVictorian : ITableCreator
    {
        public void Create()
        {
            Console.WriteLine("Create Table Victorian");
        }
    }
}
