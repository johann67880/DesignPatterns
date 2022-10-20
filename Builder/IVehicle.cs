using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public interface IVehicle
    {
        public void SetTyres();
        public void SetModel();
        public void SetLights();

        public void SetSunRoof();
        public void SetAirbags();
    }
}
