using System;
using System.Collections.Generic;
using System.Text;

namespace Isp.Vehicle
{
    internal interface IVehicleMotorcycle : IVehicle
    {
        void ConfigureMotorcycle(string color, int year, double engine);
    }
}
