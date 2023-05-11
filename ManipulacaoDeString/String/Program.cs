using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Replace
            string texto = "Ola amigos, estou muito feliz de esta aqui com voces!";
            string texto1 = texto.Replace("feliz", "Pika");
            Console.WriteLine(texto1);

            // Existencia de texto

            Console.WriteLine(texto1.Contains("Pika"));
            Console.WriteLine(texto1.StartsWith("Ola"));
            Console.WriteLine(texto1.EndsWith("!"));

            // Format

            string nome = "Samuel";

            string textoFormatado = string.Format("Ola {0}, Tudo bem?", nome);
            Console.WriteLine(textoFormatado);


            //Split

            List<string> textoQuebrado = new List<string>(texto1.Split());

            textoQuebrado.ForEach(a  => Console.WriteLine(a));
            
        }
    }
}
