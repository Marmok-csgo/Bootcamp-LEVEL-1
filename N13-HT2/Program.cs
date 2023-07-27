using N13_HT2;

class Program
{
    static void Main(string[] args)
    {
        var passwordGenerate1 = new PasswordGenerate(19, true, true);
        var passwordGenerate2 = new PasswordGenerate(14, false);

        var PG1 = new SecurePasswordGenerator(15,true, true);

        var result1 = passwordGenerate1.Generate();
        var result2 = passwordGenerate2.Generate();

        var R1 = PG1.Generate();

        Console.WriteLine($"password_1: {result1}\n" +
            $"password_2: {result2}\n" +
            $"strong_password_1: {R1}");

    }
}