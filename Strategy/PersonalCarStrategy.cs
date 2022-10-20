using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class PersonalCarStrategy : ITransportToAirport
    {
        public void TakeTransport()
        {
            Console.WriteLine("Using personal car as transport to the airport...");
        }
    }
}
