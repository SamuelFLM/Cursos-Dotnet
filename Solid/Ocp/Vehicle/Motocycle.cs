using System;
using System.Collections.Generic;
using System.Text;

namespace Ocp.Vehicle
{
    internal class Motocycle : Vehicle
    {

        public Motocycle(string color, int year, double engine) : base(color, year, engine)
        {
            ConfigureMotocycle();
        }

        public void ConfigureMotocycle()
        {
            Console.WriteLine($"Criando uma moto {color}, {year}, {engine} cilidradas");
            StartVehicle();
        }
    }
}
