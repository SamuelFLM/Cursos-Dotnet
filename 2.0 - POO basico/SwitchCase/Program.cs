using System;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ola, Deseja continuar?");
            Console.Write("RESPOSTA: ");

            string resposta = Console.ReadLine().ToLower();

            switch (resposta)
            {
                case "sim": Console.WriteLine("BEM VINDO MEU BAO"); break;
                case "nao": Console.WriteLine("FINALIZANDO"); break;
                default: Console.WriteLine("TA MALUCO NAO ENTENDO ISSO AI"); break;
            }

        }
    }
}
