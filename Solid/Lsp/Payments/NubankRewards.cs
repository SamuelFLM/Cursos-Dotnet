using System;
using System.Collections.Generic;
using System.Text;

namespace Lsp.Payments
{
    internal class NubankRewards : IPaymentsInstrument
    {
        public void CollectPayment()
        {
            Console.WriteLine("Pagamento realizado com sucesso!");
            Console.WriteLine("Pontuacao creditada");
        }

        public void Validate()
        {
            Console.WriteLine("Limite OK, Rewards OK!");
        }
    }
}
