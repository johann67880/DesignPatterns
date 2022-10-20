using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class VechicleCreator
    {
        private readonly Vehicle vehicle;

        private VechicleCreator(int tyres)
        {
            this.vehicle = new Vehicle();
            this.SetTyres(tyres);
        }

        public static VechicleCreator Create(int tyres)
        {
            return new VechicleCreator(tyres);
        }

        private VechicleCreator SetTyres(int tyres)
        {
            this.vehicle.Tyres = tyres;
            return this;
        }

        public VechicleCreator SetModel(string model)
        {
            this.vehicle.Model = model;
            return this;
        }

        public VechicleCreator SetSunRoof(bool sunroof)
        {
            this.vehicle.SunRoof = sunroof;
            return this;
        }

        public VechicleCreator SetAirBags(int airbags)
        {
            this.vehicle.AirBags= airbags;
            return this;
        }

        public Vehicle Build()
        {
            return this.vehicle;
        }
    }
}
