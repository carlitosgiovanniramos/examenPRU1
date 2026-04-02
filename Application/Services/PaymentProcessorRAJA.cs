namespace SOLIDPrinciples.Application.Services;

using System;
using System.Collections.Generic;
using System.Text;
using SOLIDPrinciples.Application.Interfaces;
using SOLIDPrinciples.Application.Models;

public class PaymentProcessorRAJA
{
    private readonly IPaymentMethodRAJA _paymentMethodRAJA;
    private readonly INotificationChannelRAJA [] _notificationChannelRAJA;

    // Constructor que inyecta la estrategia de pago y los canales de notificación

    public PaymentProcessorRAJA(IPaymentMethodRAJA paymentMethodRAJA, INotificationChannelRAJA[] notificationChannelRAJA)
    {
        _paymentMethodRAJA = paymentMethodRAJA;
        _notificationChannelRAJA = notificationChannelRAJA;
    }
    public void ExecutePaymentRAJA(PaymentRequestRAJA paymentRequestRAJA)
    {
        Console.WriteLine($"\n--- Iniciando transaccion para : {paymentRequestRAJA.UserNameRAJA} ---");

        //Procesar el pago a traves de la interfaz (sin importar si es tarjeta, efectivo, etc)
        _paymentMethodRAJA.ProcessPaymentRAJA(paymentRequestRAJA.AmountRAJA);

        string resumenRAJA = $"Pago de {paymentRequestRAJA.UserNameRAJA} procesado exitosamente mediante {_paymentMethodRAJA.GetMethodNameRAJA()}";
        Console.WriteLine(resumenRAJA);

        // 2. Notificamos por cada canal configurado (Usando un arreglo simple, no List)
        Console.WriteLine(" --- Enviando notificaciones ---");
        for (int i = 0; i < _notificationChannelRAJA.Length; i++)
        {
            _notificationChannelRAJA[i].SendNotificationRAJA(resumenRAJA);
        }
        Console.WriteLine("--------------------------------------------------\n");
    }
}
