using N13_T3;

class Program
{
    static void Main(string[] args)
    {
        BankAccount bankAccount1 = new BankAccount("Firdavs", "Tolibov");
        BankAccount bankAccount2 = new BankAccount("ALi", "Turayev", -20);



        Console.WriteLine(bankAccount1);
        Console.WriteLine(bankAccount2);
    }
}