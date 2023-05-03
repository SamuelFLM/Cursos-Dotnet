using System;

namespace EscopoVariavel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;

            // Escopo variavel. 
            while (true) { 
                //Variavel pode utilizada apenas dentro desse escopo
                int i = 0;
            }

            i = 10;
        }
    }
}
