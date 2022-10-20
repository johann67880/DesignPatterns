using System;

namespace Domain
{
    public class SeaLogistic : Logistic
    {
        public override ITransport CreateTransport(string transport)
        {
            switch(transport)
            {
                case "ship":
                    return new Ship();
                default:
                    throw new ArgumentException("Transport not found...");
            }
        }
    }
}
