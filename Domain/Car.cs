using System;

namespace Domain
{
    public class Car : ITransport
    {
        internal Car()
        {
            //setting several properties and validations here
            //property A
            //property B
            //property C
        }

        public void Deliver()
        {
            Console.WriteLine("Delivering by car...");
        }
    }
}
