using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Veiculos
{
    internal class Carro
    {
        public string Marca;
        public string Cor;
        public string Modelo;
        public bool LuzesInternas = false;

        public void AbrirPorta()
        {
            LuzesInternas = true;

        }

        public void FecharPorta()
        {
            LuzesInternas = false;
        }

        public string AcenderFarolAutomaticamente()
        {
            return "Médio";
        }


    }
}
