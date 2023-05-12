using System;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {

            byte contador = 0;
            while (contador <= 10)
            {
                Console.WriteLine($"Contador: {contador}");
                contador++; 
            }

            bool repetir = true;
            while (repetir)
            {
                if (contador == 2)
                {
                    repetir = false;
                    Console.WriteLine("Parei");
                }
                contador++;
            }
            
        }
    }
}
