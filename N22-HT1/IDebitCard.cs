namespace N22_HT1;

public interface IDebitCard
{
    string CardNumber { get; set; }
    string BankName { get; init; }
    double Balance { get; set; }
    
}


public class KapitalUzcard : IDebitCard
{
    public string CardNumber { get; set; }
    public string BankName { get; init; }
    public double Balance { get; set; }
    
    public KapitalUzcard(string cardnumber, string bankname, double balance)
    {
        CardNumber = cardnumber.Length == 16 ? cardnumber : throw new ArgumentException("Card number must be 16 characters long.");

        BankName = bankname;
        
        Balance = balance;
    }
}


public class MilliyHumo : IDebitCard
{
    public string CardNumber { get; set; }
    public string BankName { get; init; }
    public double Balance { get; set; }
    
    public MilliyHumo(string cardnumber, string bankname, double balance)
    {
        CardNumber = cardnumber.Length == 16 ? cardnumber : throw new ArgumentException("Card number must be 16 characters long.");

        BankName = bankname;
        Balance = balance;
    }
}