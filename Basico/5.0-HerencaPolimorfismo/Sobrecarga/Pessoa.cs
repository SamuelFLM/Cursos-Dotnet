using System;
using System.Collections.Generic;
using System.Text;

namespace Sobrecarga
{
    internal class Pessoa
    {

        public int Andar()
        {
            return 1;
        }

        public int Andar(int lvl)
        {
            return Andar() * lvl;
        }
               
    }
}
