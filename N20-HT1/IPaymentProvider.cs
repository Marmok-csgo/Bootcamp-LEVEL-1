namespace N22_HT1;

public interface IPaymentProvider
{
    public bool Transfer(IDebitCard sourceCard, IDebitCard destinationCard, double amount);
    
    public double TransferInterest { get; init; }
}


public class PaymePaymentProvider : IPaymentProvider
{

    public double TransferInterest { get; init; } = 2;
    
    public bool Transfer(IDebitCard sourceCard, IDebitCard destinationCard, double amount)
    {
        var AmountWithTransferInterest = amount + (amount / 100 * TransferInterest);
        if (AmountWithTransferInterest > sourceCard.Balance)
            return false;
        sourceCard.Balance -= AmountWithTransferInterest;
        destinationCard.Balance += amount;

        return true;
    }
}

public class UzumPaymentProvider : IPaymentProvider
{
    public double TransferInterest { get; init; } = 1;

    public bool Transfer(IDebitCard sourceCard, IDebitCard destinationCard, double amount)
    {
        var AmountWithTransferInterest = amount + (amount / 100 * TransferInterest);
        if (AmountWithTransferInterest > sourceCard.Balance)
            return false;

        sourceCard.Balance -= AmountWithTransferInterest;
        destinationCard.Balance += amount;

        return true;
    }    
}
