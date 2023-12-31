using AbstractFactoryPattern.FurnituresDemo.Interfaces;
using AbstractFactoryPattern.FurnituresDemo.Modern;

namespace AbstractFactoryPattern.FurnituresDemo.Factories
{
    public class ModernFactory : IFurnitureAbstractFactory
    {
        public IChairCreator CreateChair()
        {
            return new ChairModern();
        }

        public ISofaCreator CreateSofa()
        {
            return new SofaModern();
        }

        public ITableCreator CreateTable()
        {
            return new TableModern();
        }
    }
}
