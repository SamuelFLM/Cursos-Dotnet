using System;

namespace Lsp.Payments
{
    abstract class NubankCard : IPaymentsInstrument
    {
        public void CollectPayment()
        {
            Console.WriteLine("Pagamento realizado");
        }

        public virtual void Validate()
        {
            //throw new NotImplementedException();
        }


    }
}
