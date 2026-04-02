namespace SOLIDPrinciples.Application.Models;


public class PaymentRequestRAJA
{
    public decimal AmountRAJA { get; set; }
    public string UserNameRAJA { get; set; }

    public PaymentRequestRAJA(decimal amountRAJA, string userNameRAJA)
    {
        AmountRAJA = amountRAJA;
        UserNameRAJA = userNameRAJA;
    }
}