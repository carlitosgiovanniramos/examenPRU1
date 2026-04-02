namespace SOLIDPrinciples.Infrastructure.Notifications;

using System;
using System.Collections.Generic;
using System.Text;
using global::SOLIDPrinciples.Application.Interfaces;
using SOLIDPrinciples.Application.Interfaces;

public class EmailNotificationRAJA : INotificationChannelRAJA
{
    public void SendNotificationRAJA(string messageRAJA)
    {
        Console.WriteLine($"[Email RAJA] Enviando: {messageRAJA}");
    }
}
