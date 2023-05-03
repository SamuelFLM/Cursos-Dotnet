using System;
using System.Collections.Generic;
using System.Text;

namespace Pratica1
{
    internal static class  Matematica
    {
        public static void Exponeciacao(float inputUsuario, float potencia)
        {
            double calculo = Math.Pow(inputUsuario, potencia);
            Console.WriteLine($"Seu resultado: {calculo}");
        }
    }
}
