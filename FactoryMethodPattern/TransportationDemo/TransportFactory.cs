namespace FactoryMethodPattern.TransportationDemo
{
    public class TransportFactory
    {
        private TransportFactory() { }

        public static ITransport GetTransport(TransportType transportType)
        {
            switch (transportType)
            {
                case TransportType.TRUCK:
                    return new Truck();
                case TransportType.SHIP:
                    return new Ship();
                default:
                    throw new ArgumentException("This transport type is unsupported.");
            }
        }
    }
}
