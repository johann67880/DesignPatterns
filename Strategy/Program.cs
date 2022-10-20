using System;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string transport = "bus";
            var context = new Context();
            switch(transport)
            {
                case "bus":
                    context.SetStrategy(new BusStrategy());
                    break;
                case "taxi":
                    context.SetStrategy(new TaxiStrategy());
                    break;
                case "car":
                    context.SetStrategy(new PersonalCarStrategy());
                    break;
                    default:
                    throw new Exception("Transport not found...");
            }

            //Alternative 1
            context.ExecuteStrategy();

            //Alternative 2
            var context2 = new Context2();
            context2.ExecuteStrategy(transport);
        }
    }
}
