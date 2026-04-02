namespace SOLIDPrinciples.Infrastructure.Payments
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using SOLIDPrinciples.Application.Interfaces;

    public class CashPaymentRAJA : IPaymentMethodRAJA
    {
        public void ProcessPaymentRAJA(decimal amountRAJA)
        {
            Console.WriteLine($"[Efectivo] RAJA: Validando recepción de billetes por ${amountRAJA}...");
        }

        public string GetMethodNameRAJA()
        {
            return "Efectivo RAJA";
        }
    }
}
