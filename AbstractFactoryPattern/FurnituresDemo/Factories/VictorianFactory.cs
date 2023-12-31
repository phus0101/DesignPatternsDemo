using AbstractFactoryPattern.FurnituresDemo.Interfaces;
using AbstractFactoryPattern.FurnituresDemo.Victorian;

namespace AbstractFactoryPattern.FurnituresDemo.Factories
{
    public class VictorianFactory : IFurnitureAbstractFactory
    {
        public IChairCreator CreateChair()
        {
            return new ChairVictorian();
        }

        public ISofaCreator CreateSofa()
        {
            return new SofaVictorian();
        }

        public ITableCreator CreateTable()
        {
            return new TableVictorian();
        }
    }
}
