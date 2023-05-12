using System;
using System.Collections.Generic;

namespace Exercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<short> valores = new List<short>();
            
            for (int i = 0; i < 2; i++)
            {
                valores.Add(short.Parse(Console.ReadLine()));    
            }

            Console.WriteLine($"SOMA = {valores[0] + valores[1]}");
        }
    }
}
