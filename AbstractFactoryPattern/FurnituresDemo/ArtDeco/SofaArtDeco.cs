using AbstractFactoryPattern.FurnituresDemo.Interfaces;

namespace AbstractFactoryPattern.FurnituresDemo.ArtDeco
{
    public class SofaArtDeco : ISofaCreator
    {
        public void Create()
        {
            Console.WriteLine("Create Sofa ArtDeco");
        }
    }
}
