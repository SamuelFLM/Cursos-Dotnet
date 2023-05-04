using System;
using System.Collections.Generic;
using System.Text;

namespace Construtor
{
    internal class Carro
    {
        public string Marca;
        public string Modelo;
        public int Ano;

        public Carro(string marca, string modelo, int ano)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Ano = ano;
        }

        public string ModeloCarro()
        {
            return this.Modelo;
        }
    }
}
