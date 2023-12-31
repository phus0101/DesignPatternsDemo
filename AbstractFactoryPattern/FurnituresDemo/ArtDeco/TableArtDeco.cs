using AbstractFactoryPattern.FurnituresDemo.Interfaces;

namespace AbstractFactoryPattern.FurnituresDemo.ArtDeco
{
    public class TableArtDeco : ITableCreator
    {
        public void Create()
        {
            Console.WriteLine("Create Table ArtDeco");
        }
    }
}
