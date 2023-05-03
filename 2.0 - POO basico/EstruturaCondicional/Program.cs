using System;

namespace EstruturaCondicional_IF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Estrutura IF, ELSE IF, ELSE


            Console.Write("Informe sua idade: ");
            try
            {
                byte idade = byte.Parse(Console.ReadLine());

                if (idade >= 18)
                {
                    Console.WriteLine("Maior de idade");
                }
                else if(idade == 15){
                    Console.WriteLine("Seu pirralho");
                }
                else
                {
                    Console.WriteLine("Menor de idade");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ta maluco porra");
            }
        }
    }
}
