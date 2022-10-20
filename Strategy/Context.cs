using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Linq;

namespace Strategy
{
    //First option
    public class Context
    {
        private ITransportToAirport transportToAirport;

        public void SetStrategy(ITransportToAirport _transportToAirport)
        {
            transportToAirport = _transportToAirport;
        }

        public void ExecuteStrategy()
        {
            transportToAirport.TakeTransport();
        }
    }

    //Reflection: Another Option to use Strategy
    public class Context2
    {
        public void ExecuteStrategy(string transport)
        {
            var concreteStrategy = Assembly.GetExecutingAssembly().GetTypes()
                .FirstOrDefault(x => x.Name.Equals($"{transport}Strategy", StringComparison.InvariantCultureIgnoreCase));

            ITransportToAirport instance = (ITransportToAirport)Activator.CreateInstance(concreteStrategy);
            instance.TakeTransport();
        }
    }
}
