using Dip.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dip.Payments
{
    internal class PaymentsProcess
    {

        public void Pay(string id)
        {
            SQLServerProduct product = new SQLServerProduct();
            string productData = product.GetProductById(id);

            Console.WriteLine(productData);
        }
    }
}
