using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace Exercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] pesos = { 3.5f, 7.5f };
            var notas = new List<float>();

            for (int i = 0; i < pesos.Length; i++)
            {
                notas.Add(float.Parse(Console.ReadLine())); 
            }

            float media = ((notas[0] * pesos[0]) + (notas[1] * pesos[1]))  / 11;
            Console.WriteLine($"MEDIA = {media.ToString("F5")}");

        }
    }
}
