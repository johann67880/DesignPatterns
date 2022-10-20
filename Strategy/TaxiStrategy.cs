using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class TaxiStrategy : ITransportToAirport
    {
        public void TakeTransport()
        {
            Console.WriteLine("Using taxi as transport to the airport...");
        }
    }
}
