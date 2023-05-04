using System;
using System.Collections.Generic;
using System.Text;

namespace Sobrescrita.Biblioteca
{
    internal class Veiculo
    {
        public string Marca;
        public int QuantidadeMaxPassageiros;
        public int Ano;
        public string Modelo;

        public virtual void Mover()
        {
            Console.WriteLine("Mover chamado dentro de: Veiculo.Mover");
        }
    }
}
