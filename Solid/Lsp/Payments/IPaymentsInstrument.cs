using System;
using System.Collections.Generic;
using System.Text;

namespace Lsp.Payments
{
    internal interface IPaymentsInstrument
    {
        void Validate();

        void CollectPayment();

    }
}
