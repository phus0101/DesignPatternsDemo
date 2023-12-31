using AbstractFactoryPattern.FurnituresDemo.Interfaces;

namespace AbstractFactoryPattern.FurnituresDemo.Modern
{
    public class TableModern : ITableCreator
    {
        public void Create()
        {
            Console.WriteLine("Create Table Modern");
        }
    }
}
