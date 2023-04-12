using System;

namespace ExercicioOutputInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Informe sua idade: ");
            byte idade = byte.Parse(Console.ReadLine());

            int calculoIdade = (DateTime.Now.Year - 1) - idade;

            Console.WriteLine($"Seu nome é {nome}");
            Console.WriteLine($"Voce nasceu no ano {calculoIdade}");
        }
    }
}
