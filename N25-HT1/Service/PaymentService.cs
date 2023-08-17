using N25_HT1.Model;

namespace N25_HT1.Service;

public class PaymentService
{
    public bool CheckOut(double amount, DebitCard card)
    {
        if (amount <= card.Balance)
        {
            card.Balance -= amount;
            return true;
        }
        return false;
    }
}