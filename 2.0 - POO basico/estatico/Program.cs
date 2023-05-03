using Estatico;
using System;

namespace estatico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Carro.QuantidadeCarrosProduzidos = 200;

            Console.WriteLine($"Quantidade de carros produzidos: {Carro.QuantidadeCarrosProduzidos}");

        }
    }
}
