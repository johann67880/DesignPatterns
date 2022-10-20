using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Domain
{
    public static class TransportFactory
    {
        public static ITransport CreateTransport(string transport) =>
            GetTransport(transport);

        private static ITransport GetTransport(string transport) => transport switch
        {
            "car" => new Car(),
            "ship" => new Ship(),
            _ => throw new ArgumentException("Transport not found")
        };        
    }

    //Another Way: Getting rid of Switch ir If-Else statements
    public class TransportFactory2
    {
        private readonly Dictionary<string, Func<ITransport>> transports;

        public TransportFactory2()
        {
            transports = new Dictionary<string, Func<ITransport>>();

            //If you are using WebApplication move this code to Startup class inside of ConfigureServices method
            RegisterTransport("ship", () => new Ship());
            RegisterTransport("car", () => new Car());
        }

        public ITransport GetTransport(string transport) => transports[transport]();

        public List<string> registeredTransports => transports.Keys.ToList();

        public void RegisterTransport(string transport, Func<ITransport> factoryMethod)
        {
            if (string.IsNullOrEmpty(transport)) return;

            if (factoryMethod is null) return;

            transports[transport] = factoryMethod;
        }
    }

    //Another Way: Using Reflection
    public class TransportFactory3
    {
        public static ITransport Create(string transport)
        {
            var concreteClass = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(x => x.Name.Equals(transport, StringComparison.InvariantCultureIgnoreCase));
            return (ITransport)Activator.CreateInstance(concreteClass);
        }
    }
}
