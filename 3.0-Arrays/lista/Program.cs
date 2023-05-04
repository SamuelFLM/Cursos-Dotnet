using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> idade = new List<int>();

            idade.Add(21);


            Console.WriteLine(idade[0]);

            var nomes = new List<string>();


            nomes.Add("Samuel");
            nomes.Add("Felipe");

            nomes.ForEach(nome => Console.WriteLine(nome));
        }
    }
}
