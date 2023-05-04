using System;

namespace Construtor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Carro carro = new Carro("PEGEOUT", "208", 2022);
            string modeloCarro = carro.ModeloCarro();

            Console.WriteLine(modeloCarro); 
        }
    }
}
