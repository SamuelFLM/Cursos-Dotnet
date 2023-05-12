using Polimorfismo.Biblioteca;
using Polimorfismo.Biblioteca.Derivada;
using System;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();  
            MoverVeiculo(carro);
        }

        public static void MoverVeiculo(Veiculo veiculo)
        {
            veiculo.Mover();
        }

    }
}
