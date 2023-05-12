using System;
using System.Linq;

namespace Pratica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[2];
            string[] colocacao = { "primeiro", "segundo" };

            for (int i = 0; i < 2; i++)
            {
                Console.Write($"INFORME O {colocacao[i]} NUMERO: ");
                int valor = int.Parse(Console.ReadLine());
                valores[i] = valor;
            }

            Matematica.Exponeciacao(valores[0], valores[1]);
        }
    }
}
