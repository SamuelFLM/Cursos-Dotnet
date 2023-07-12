using System;
using System.Collections.Generic;
using System.Text;

namespace Dip.Model
{
    internal class SQLServerProduct
    {

        public string GetProductById(string id)
        {
            return $"SQLServer: Exibindo dados do produto {id}.";
        }
    }
}
