using AbstractFactoryPattern.FurnituresDemo.ArtDeco;
using AbstractFactoryPattern.FurnituresDemo.Interfaces;

namespace AbstractFactoryPattern.FurnituresDemo.Factories
{
    public class ArtDecoFactory : IFurnitureAbstractFactory
    {
        public IChairCreator CreateChair()
        {
            return new ChairArtDeco();
        }

        public ISofaCreator CreateSofa()
        {
            return new SofaArtDeco();
        }

        public ITableCreator CreateTable()
        {
            return new TableArtDeco();
        }
    }
}
