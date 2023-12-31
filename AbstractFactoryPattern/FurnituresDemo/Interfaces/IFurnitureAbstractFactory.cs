namespace AbstractFactoryPattern.FurnituresDemo.Interfaces
{
    public interface IFurnitureAbstractFactory
    {
        IChairCreator CreateChair();

        ISofaCreator CreateSofa();

        ITableCreator CreateTable();
    }
}
