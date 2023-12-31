using AbstractFactoryPattern.FurnituresDemo.Interfaces;

namespace AbstractFactoryPattern.FurnituresDemo.Victorian
{
    public class ChairVictorian : IChairCreator
    {
        public void Create()
        {
            Console.WriteLine("Create Chair Victorian");
        }
    }
}
