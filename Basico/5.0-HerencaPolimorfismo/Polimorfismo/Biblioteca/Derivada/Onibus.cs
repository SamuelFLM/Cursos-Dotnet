﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo.Biblioteca.Derivada
{
    internal class Onibus : Veiculo
    {
        public override void Mover()
        {
            Console.WriteLine("Onibus se movendo!");
        }
    }
}
