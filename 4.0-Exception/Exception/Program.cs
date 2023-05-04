using System;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");

            try
            {
                int numero = int.Parse(Console.ReadLine());
            }
            catch (Exception) {
                Console.WriteLine("Nao digitou  valor correto");
            }
            finally { Console.WriteLine("Finally"); }

            Console.ReadKey();
        }
    }
}
