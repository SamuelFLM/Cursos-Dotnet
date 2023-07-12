using Ocp.Vehicle;
using System;
using System.Numerics;

namespace Ocp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TypeVehicle type = TypeVehicle.CAR;

            if ( type == TypeVehicle.CAR )
            {
                Car vehicle = new Car("Azul", 2022, 2.0, 5, 4);
            }
            else
            {
                Motocycle vehicle = new Motocycle("Branco", 2023, 250);
            }

            Console.ReadLine();
        }
    }
}
