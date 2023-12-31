using AbstractFactoryPattern.FurnituresDemo.Interfaces;

namespace AbstractFactoryPattern.FurnituresDemo.Factories
{
    public class FurnitureFactory
    {
        private FurnitureFactory() { }

        public static IFurnitureAbstractFactory GetFactory(StyleType styleType)
        {
            return styleType switch
            {
                StyleType.ARTDECO => new ArtDecoFactory(),
                StyleType.VICTORIAN => new VictorianFactory(),
                StyleType.MODERN => new ModernFactory(),
                _ => throw new ArgumentException("This furniture is unsupported."),
            };
        }
    }
}
