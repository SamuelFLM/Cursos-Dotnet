using System;
using HerencaPolimorfismo.Biblioteca;
namespace HerencaPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();  
            Moto moto = new Moto();
            Veiculo veiculo = new Veiculo();

            carro.QuantidadeMaxPassageiros = 5;
            carro.Marca = "FIAT";

            

        }
    }
}
