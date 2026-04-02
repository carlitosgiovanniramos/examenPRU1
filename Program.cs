using System;
using SOLIDPrinciples.Application.Interfaces;
using SOLIDPrinciples.Application.Models;
using SOLIDPrinciples.Application.Services;
using SOLIDPrinciples.Infrastructure.Notifications;
using SOLIDPrinciples.Infrastructure.Payments;

Console.WriteLine("=== INICIANDO SISTEMA DE PAGOS RAJA ===\n");

// 1. Definimos los canales de notificación (Arreglo normal, prohibido el uso de List<T>)
INotificationChannelRAJA[] canalesDeNotificacionRAJA = new INotificationChannelRAJA[]
{
    new EmailNotificationRAJA(),
    new WhatsappNotificationRAJA()
};

// ==========================================
// ESCENARIO 1: PAGO CON TARJETA DE CRÉDITO
// ==========================================

// 2. Instanciamos el método de pago específico
IPaymentMethodRAJA metodoTarjetaRAJA = new CreditCardPaymentRAJA();

// 3. Inyectamos las dependencias por el constructor al Procesador
PaymentProcessorRAJA procesadorTarjetaRAJA = new PaymentProcessorRAJA(metodoTarjetaRAJA, canalesDeNotificacionRAJA);

// 4. Creamos los datos de la transacción (Hardcodeados internamente como pide el examen)
PaymentRequestRAJA peticionTarjetaRAJA = new PaymentRequestRAJA(150.00m, "Juan Pérez");

// 5. Ejecutamos
procesadorTarjetaRAJA.ExecutePaymentRAJA(peticionTarjetaRAJA);

Console.WriteLine("\n=== PROCESANDO PAGO EN EFECTIVO===\n");
// ==========================================
// ESCENARIO 1: PAGO CON TARJETA DE CRÉDITO
// ==========================================

// 2. Instanciamos el método de pago específico
IPaymentMethodRAJA metodoEfectivoRAJA = new CashPaymentRAJA();

// 3. Inyectamos las dependencias por el constructor al Procesador
PaymentProcessorRAJA procesadorEfectivo = new PaymentProcessorRAJA(metodoEfectivoRAJA, canalesDeNotificacionRAJA);

// 4. Creamos los datos de la transacción (Hardcodeados internamente como pide el examen)
PaymentRequestRAJA peticionEfectivo = new PaymentRequestRAJA(80.00m, "María Gómez");

// 5. Ejecutamos
procesadorEfectivo.ExecutePaymentRAJA(peticionEfectivo);

Console.WriteLine("=== FIN DEL PROCESAMIENTO ===");