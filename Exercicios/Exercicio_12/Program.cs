using System;
using System.Collections.Generic;

namespace Exercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<float> valores = new List<float>();

            for (int i = 0; i < 3; i++)
            {
                valores.Add(float.Parse(Console.ReadLine()));
            }

            float areaTrianguloRetangulo = (float)((valores[0] * valores[2]) / 2);
            float areaCirculoDeRaio = (float)(3.14159 * Math.Pow(valores[2], 2));
            float areaTrapezio = (float)(((valores[0] + valores[1]) * valores[2]) / 2);
            float areaQuadrado = (float)(Math.Pow(valores[1], 2));
            float areaRetangulo = (float)(valores[0] * valores[1]);

            Console.WriteLine($"TRIANGULO = {areaTrianguloRetangulo.ToString("F3")}");
            Console.WriteLine($"CIRCULO = {areaCirculoDeRaio.ToString("F3")}");
            Console.WriteLine($"TRAPEZIO = {areaTrapezio.ToString("F3")}");
            Console.WriteLine($"QUADRADO = {areaQuadrado.ToString("F3")}");
            Console.WriteLine($"RETANGULO = {areaRetangulo.ToString("F3")}");

        }
    }
}
