using System;
using System.Collections.Generic;

namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var valores = new List<int>();

            for (int i = 0; i < 2; i++)
            {
                valores.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine($"X = {valores[0] + valores[1]}");
        }
    }
}
