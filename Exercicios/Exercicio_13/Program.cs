using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<byte> maior = new List<byte>();

            for (int i = 0; i < 3; i++) { maior.Add(byte.Parse(Console.ReadLine())); }

            Console.WriteLine($"{maior.Max()} eh o maior");
        }
    }
}
