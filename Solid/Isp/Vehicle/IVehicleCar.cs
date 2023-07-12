using System;
using System.Collections.Generic;
using System.Text;

namespace Isp.Vehicle
{
    internal interface IVehicleCar : IVehicle
    {
        void ConfigureCar(string color, int year, double engine, int seats, int doors);
    }
}
