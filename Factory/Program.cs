using Domain;

namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string transportOption = "ship";

            //first alternative
            var factory = TransportFactory.CreateTransport(transportOption);
            factory.Deliver();

            //second alternative: using Dictionary and Func
            var secondFactory = new TransportFactory2();
            ITransport transport = secondFactory.GetTransport(transportOption);
            transport.Deliver();

            //third alternative: using reflection
            var thirdFactory = TransportFactory3.Create(transportOption);
            thirdFactory.Deliver();
        }
    }
}
