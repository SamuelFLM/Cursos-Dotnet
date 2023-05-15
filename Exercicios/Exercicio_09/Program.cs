using System;
using System.Collections.Generic;

namespace Exercicio_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<float> inputSalario = new List<float>();
            string  nome = Console.ReadLine();

            for (int i = 0; i <2; i++) { inputSalario.Add(float.Parse(Console.ReadLine())); }

            float caluloSalarioBonus = (inputSalario[1] * 0.15f) + inputSalario[0];
            Console.WriteLine($"TOTAL =  {caluloSalarioBonus.ToString("F2")}");
        }
    }
}
