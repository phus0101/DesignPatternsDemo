using AbstractFactoryPattern.FurnituresDemo.Interfaces;

namespace AbstractFactoryPattern.FurnituresDemo.Modern
{
    public class ChairModern : IChairCreator
    {
        public void Create()
        {
            Console.WriteLine("Create Chair Modern");
        }
    }
}
