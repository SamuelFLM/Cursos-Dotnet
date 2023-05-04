using System;

namespace Array_Multidimesional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] marcas = new string[3,4];


            marcas[0, 0] = "FIAT";
            marcas[0, 1] = "Honda";
            marcas[0, 2] = "CAMARO";
            marcas[0, 3] = "Pegeout";


            marcas[1, 0] = "HP";
            marcas[1, 1] = "Positivo";
            marcas[1, 2] = "DELL";
            marcas[1, 3] = "AGON";

            marcas[2, 0] = "ROUPA";
            marcas[2, 1] = "PENTE";
            marcas[2, 2] = "COMPUTADOR";
            marcas[2, 3] = "TECLADO";


            // OU

            string[,] nomes = new string[,] { {"FIAT", "UNO" }, {"DELL","AGON" }, {"ROUPA", "COMPUTADOR" } };
        }
    }
}
