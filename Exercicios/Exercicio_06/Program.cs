using System;
using System.Collections.Generic;

namespace Exercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] pesos = { 2, 3, 5 };
            List<byte> valores = new List<byte>();

            for (int i = 0; i < pesos.Length; i++)
            {
                valores.Add(byte.Parse(Console.ReadLine()));
            }

            float calculo = (float)((valores[0] * pesos[0]) + (valores[1] * pesos[1]) + (valores[2] *pesos[2])) / 10;

            Console.WriteLine($"MEDIA =  {calculo}");
        }
    }
}
