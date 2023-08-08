using N16_T1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Email:");
        var email = Console.ReadLine();

        Console.Write("Enter Password:");
        var pass = Console.ReadLine();

        Console.Write("Enter Name:");
        var name = Console.ReadLine();

        var emailServise = new EmailService(email, pass, name);

        emailServise.SendEmail(email, name);
    }
}