using System;

namespace Exercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float valorPi = 3.14159f;
            float inputUsuario = float.Parse(Console.ReadLine());   
            float area = valorPi * (float)Math.Pow(inputUsuario, 2);
            Console.WriteLine($"{area.ToString("F4")}");
        }
    }
}
