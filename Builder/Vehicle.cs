using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Vehicle
    {
        public Vehicle()
        {

        }
        public Vehicle(int tyres, string model, int lights, bool sunroof, int airbags)
        {

        }

        public Vehicle(int tyres, string model, int lights)
        {

        }

        public int Tyres { get; set; }
        public string Model { get; set; }
        public int Lights { get; set; }
        public bool SunRoof { get; set; }
        public int AirBags { get; set; }

    }
}
