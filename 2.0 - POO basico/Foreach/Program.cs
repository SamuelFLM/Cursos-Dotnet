using System;

namespace Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = { "Samuel", "Felipe", "Lima" };

            foreach(string nome in nomes)
            {
                Console.WriteLine(nome);
            }

            //Utilizando o for

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine(nomes[i]);
            }
        }
    }
}
