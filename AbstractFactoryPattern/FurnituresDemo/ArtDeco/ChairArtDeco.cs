using AbstractFactoryPattern.FurnituresDemo.Interfaces;

namespace AbstractFactoryPattern.FurnituresDemo.ArtDeco
{
    public class ChairArtDeco : IChairCreator
    {
        public void Create()
        {
            Console.WriteLine("Create Chair ArtDeco");
        }
    }
}
