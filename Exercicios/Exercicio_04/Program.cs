using System;
using System.Collections.Generic;

namespace Exercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var valores = new List<short>();

            for (int i = 0; i < 2; i++) { valores.Add(short.Parse(Console.ReadLine())); }
            Console.WriteLine($"PROD = {valores[0] * valores[1]}");

        }
    }
}
