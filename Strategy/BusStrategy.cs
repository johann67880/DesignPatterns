using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class BusStrategy : ITransportToAirport
    {
        public void TakeTransport()
        {
            Console.WriteLine("Using bus as transport to the airport...");
        }
    }
}
