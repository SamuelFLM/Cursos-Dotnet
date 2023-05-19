using System;

namespace Exercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numeroPI = float.Parse(Math.PI.ToString("F5"));

            float raio = float.Parse(Console.ReadLine());

            float volume = (float)((4.0 / 3) * numeroPI * Math.Pow(raio, 3));

            Console.WriteLine($"VOLUME = {volume.ToString("F3")}");
        }
    }
}
