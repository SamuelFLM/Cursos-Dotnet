using System;
using System.Collections.Generic;
using System.Text;

namespace Revisao_POO
{
    internal class Pessoa
    {
        public string Nome;
        public string Sexo;
        public DateTime DataNascimento;
        public double PosicaoX, PosicaoY;

        public Pessoa(string nome, string sexo, DateTime dataNascimento, double posicaoX, double posicaoY)
        {
            Nome = nome;
            Sexo = sexo;
            DataNascimento = dataNascimento;
            PosicaoX = posicaoX;
            PosicaoY = posicaoY;
        }

        public string ResumoPessoa() {

            string resumo = $"Nome: {this.Nome}\nSexo: {Sexo}\nData Nascimento: {DataNascimento}\n";
            return resumo;
        }

        public string GetPosicao()
        {
            return $"{PosicaoX}, {PosicaoY}";
        }

    }
}
