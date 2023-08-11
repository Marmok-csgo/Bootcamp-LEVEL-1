namespace N23_T1;

class Program
{
    static void Main()
    {
        var user = new RegistrationServicedan();
        user.Register("MrAke", 1234);
        user.Register("AkeTostoboy", 4321);
        user.Register("TOG'O", 5555);
        
        Console.Write("Enter Email: ");
        string? email = Console.ReadLine();
        Console.Write("Enter Pass: ");
        var pass = Convert.ToInt32(Console.ReadLine());
        
        
        user.Register(email, pass);
    }
}