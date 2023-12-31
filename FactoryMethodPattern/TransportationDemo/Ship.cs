namespace FactoryMethodPattern.TransportationDemo
{
    public class Ship : ITransport
    {
        public void Delivery()
        {
            Console.WriteLine("Sea Transport");
        }
    }
}
