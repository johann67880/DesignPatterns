using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class RoadLogistic : Logistic
    {
        public override ITransport CreateTransport(string transport)
        {
            switch(transport)
            {
                case "car":
                    return new Car();
                    break;
                default:
                    throw new ArgumentException("Transport not found...");
            }
        }
    }
}
