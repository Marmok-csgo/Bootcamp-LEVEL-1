namespace N22_HT2;

class Program
{
    static void Main()
    {
        var register = new RegistrationService();

        Console.Write("Enter a Name: ");
        var name = Console.ReadLine();

        Console.Write("Enter a Surname: ");
        var surname = Console.ReadLine();

        Console.Write("Enter a Father'sName: ");
        var fname = Console.ReadLine();

        Console.Write("Enter an Email: ");
        var emailAddress = Console.ReadLine();

        Console.Write("Enter an UserName: ");
        var username = Console.ReadLine();



        register.Register(name, surname, fname, emailAddress, username);
        register.Display();
    }
}

