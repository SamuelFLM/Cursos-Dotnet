using Dip.Payments;
using System;

namespace Dip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentsProcess payments = new PaymentsProcess();
            payments.Pay("ABC123");

            
        }
    }
}
