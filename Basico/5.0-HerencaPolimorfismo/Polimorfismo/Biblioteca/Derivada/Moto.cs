﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo.Biblioteca.Derivada
{
    internal class Moto : Veiculo
    {
        public override void Mover()
        {
            Console.WriteLine("Moto se movendo!");
        }
    }
}
