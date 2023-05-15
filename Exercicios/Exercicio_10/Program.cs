using System;

namespace Exercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[,] valores = new float[2,3];

            int contador = 0;

            while (contador < 2) { 

                for (int j = 0; j < 3; j++)
                {
                    valores[contador,j] = float.Parse(Console.ReadLine());
                }

                contador++;
            }

            float calculo = (valores[0,1] * valores[0,2]) + (valores[1,1] * valores[1,2]);

            Console.WriteLine($"Valor a pagar: R$ {calculo.ToString("F2")}");
        }
    }
}
