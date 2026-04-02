namespace SOLIDPrinciples.Infrastructure.Payments;

using System;
using System.Collections.Generic;
using System.Text;
using SOLIDPrinciples.Application.Interfaces;

public class CreditCardPaymentRAJA : IPaymentMethodRAJA
{
    public void ProcessPaymentRAJA(decimal amountRAJA) // Nota: asegúrate que el nombre y parámetros coincidan con tu interfaz IPaymentMethodRAJA
    {
        Console.WriteLine($"[Tarjeta de Crédito] RAJA: Procesando pago de ${amountRAJA}...");
        // Aquí iría la lógica real de conexión con la pasarela (Visa, Mastercard, etc.)
    }

    public string GetMethodNameRAJA()
    {
        return "Tarjeta de Crédito RAJA";
    }
}

