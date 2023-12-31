using AbstractFactoryPattern.FurnituresDemo.Interfaces;

namespace AbstractFactoryPattern.FurnituresDemo.Victorian
{
    public class SofaVictorian : ISofaCreator
    {
        public void Create()
        {
            Console.WriteLine("Create Sofa Victorian");
        }
    }
}
