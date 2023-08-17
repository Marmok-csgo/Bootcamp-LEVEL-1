public enum MoneyType
{
    InBalance,
    Loan
}

public enum Currency
{
    Uzs,
    Usd,
    Rub
}

public class Money
{
    public decimal Amount { get; set; }
    public Currency Currency { get; set; }
    public MoneyType Type { get; set; }

    public Money(decimal amount, Currency currency, MoneyType type)
    {
        Amount = amount;
        Currency = currency;
        Type = type;
    }

    public static decimal? operator +(Money moneyA, Money moneyB)
    {
        if (moneyA.Type.Equals(moneyB.Type))
            return moneyA.Amount + moneyB.Amount;

        if (moneyA.Type == MoneyType.InBalance && moneyB.Type == MoneyType.Loan)
            return moneyA.Amount - moneyB.Amount;

        if (moneyA.Type == MoneyType.Loan && moneyB.Type == MoneyType.InBalance)
            return moneyB.Amount - moneyA.Amount;

        return null;
    }

    public void ConvertToUzs()
    {
        if (Currency == Currency.Usd)
            Amount *= 1.79549m;
        else if (Currency == Currency.Rub)
            Amount *= 60.76m;
    }
}