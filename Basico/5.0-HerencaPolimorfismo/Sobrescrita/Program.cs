using Sobrescrita.Biblioteca;
using System;

namespace Sobrescrita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();  
            Moto moto = new Moto(); 
            Veiculo veiculo = new Veiculo();


            carro.Mover();
            moto.Mover();
            veiculo.Mover();   

            Console.ReadKey();  
        }
    }
}
