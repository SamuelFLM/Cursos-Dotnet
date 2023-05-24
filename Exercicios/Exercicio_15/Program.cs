using System;
using System.Collections.Generic;

namespace Exercicio_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var valores = new List<float>();

            for (int i = 0; i < 4; i++) { valores.Add(float.Parse(Console.ReadLine())); }

            float distancia = (float)Math.Sqrt((Math.Pow(valores[2] - valores[0], 2)  + Math.Pow(valores[3] - valores[1], 2)));

            Console.WriteLine(distancia.ToString("F4"));
        }
    }
}
