using System;
using System.Collections.Generic;

namespace Dicionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dicionario = new Dictionary<string, int>();


            dicionario.Add("Samuel", 20);
            dicionario.Add("Felipe", 21);


            Console.WriteLine(dicionario["Samuel"]);

        }
    }
}
