using System;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Basic car:
            new Vehicle(4, "suzuki", 2);

            //Premium car with sunroof y airbags
            new Vehicle(4, "suzuki", 4, true, 6);

            var vehicleBuilder = VechicleCreator
                .Create(4)
                .SetModel("suzuki")
                .SetAirBags(6)
                .SetSunRoof(true)
                .Build();
        }
    }
}
