using System;
using System.Collections.Generic;

namespace Exercicio_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, float> dicionarioConsumo = new Dictionary<string, float>();
            string[] consumo = { "Distancia", "Combustivel" };

            for (int i = 0; i < consumo.Length; i++)
            {
                dicionarioConsumo.Add(consumo[i], float.Parse(Console.ReadLine()));
            }

            Console.WriteLine($"{(dicionarioConsumo["Distancia"] / dicionarioConsumo["Combustivel"]).ToString("F3")} km/l");
        }
    }
}
