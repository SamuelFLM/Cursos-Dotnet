﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo.Biblioteca.Derivada
{
    internal class Carro : Veiculo
    {
        public override void Mover()
        {
            Console.WriteLine("Carro se movendo!");
        }
    }
}
