namespace FactoryMethodPattern.TransportationDemo
{
    public class Truck : ITransport
    {
        public void Delivery()
        {
            Console.WriteLine("Road Transport");
        }
    }
}
