using System;
using System.Collections.Generic;

namespace Exercicio_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> valores = new List<string>();

            for (int i = 0; i < 3; i++) { valores.Add(Console.ReadLine()); }
            float salary = float.Parse(valores[1]) * float.Parse(valores[2]);

            Console.WriteLine($"NUMBER = {valores[0]}");
            Console.WriteLine($"SALARY = {salary.ToString("F2")}");
        }
    }
}
