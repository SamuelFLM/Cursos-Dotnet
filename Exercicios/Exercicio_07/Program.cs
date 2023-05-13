using System;
using System.Collections.Generic;

namespace Exercicio_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<short> valores = new List<short>();

            for (int i = 0; i <= 3; i++)
            {
                valores.Add(short.Parse(Console.ReadLine()));   
            }

            short diferenca = (short)((valores[0] * valores[1]) - (valores[2] * valores[3]));

            Console.WriteLine($"DIFERENCA = {diferenca}");
        }
    }
}
