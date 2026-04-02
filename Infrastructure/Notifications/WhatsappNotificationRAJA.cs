namespace SOLIDPrinciples.Infrastructure.Notifications;

using System;
using System.Collections.Generic;
using System.Text;
using SOLIDPrinciples.Application.Interfaces;

public class WhatsappNotificationRAJA : INotificationChannelRAJA
{
    public void SendNotificationRAJA(string messageRAJA)
    {
        Console.WriteLine($"[Whatsapp RAJA] Enviando: {messageRAJA}");
    }
}
