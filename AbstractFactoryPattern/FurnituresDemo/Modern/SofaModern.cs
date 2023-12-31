using AbstractFactoryPattern.FurnituresDemo.Interfaces;

namespace AbstractFactoryPattern.FurnituresDemo.Modern
{
    public class SofaModern : ISofaCreator
    {
        public void Create()
        {
            Console.WriteLine("Create Sofa Modern");
        }
    }
}
