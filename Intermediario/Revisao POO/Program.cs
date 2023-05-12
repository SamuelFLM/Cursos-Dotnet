using System;

namespace Revisao_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("Samuel", "M", new DateTime(2002, 08, 27),20,70);

            string texto = pessoa.ResumoPessoa();
            Console.WriteLine(texto);

            string posicao =pessoa.GetPosicao();
            Console.WriteLine(posicao);

        }
    }
}
