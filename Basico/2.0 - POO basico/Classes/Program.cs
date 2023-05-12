using System;
using Classes.Veiculos;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();

            Console.WriteLine($"Luzes Internas: {carro.LuzesInternas}");

            carro.AbrirPorta();
            Console.WriteLine($"Luzes Internas: {carro.LuzesInternas}");


        }
    }
}
