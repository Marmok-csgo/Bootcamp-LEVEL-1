namespace N26_HT1;

class Program
{
    static void Main(string[] args)
    {
        List<Money> moneyList = new List<Money>
        {
            new Money(100.00m, Currency.Uzs, MoneyType.InBalance),
            new Money(50.00m, Currency.Usd, MoneyType.InBalance),
            new Money(200.00m, Currency.Rub, MoneyType.Loan),
            new Money(75.00m, Currency.Uzs, MoneyType.InBalance),
            new Money(150.00m, Currency.Usd, MoneyType.Loan),
            new Money(25.00m, Currency.Rub, MoneyType.InBalance),
            new Money(50.00m, Currency.Usd, MoneyType.InBalance),
            new Money(10.00m, Currency.Uzs, MoneyType.Loan),
            new Money(5.00m, Currency.Rub, MoneyType.Loan),
            new Money(100.00m, Currency.Uzs, MoneyType.InBalance)
        };

        decimal totalInBalanceUzs = 0;
        decimal totalLoanUzs = 0;

        foreach (var money in moneyList)
        {
            if (money.Type == MoneyType.InBalance)
            {
                money.ConvertToUzs();
                totalInBalanceUzs = totalLoanUzs + money.Amount;
            }

            else if (money.Type == MoneyType.Loan)
            {
                money.ConvertToUzs();
                totalLoanUzs = totalLoanUzs + money.Amount;
            }
        }

        Console.WriteLine($"Total in balance UZS: {totalInBalanceUzs}");
        Console.WriteLine($"Total loan UZS: {totalLoanUzs}");
    }
}