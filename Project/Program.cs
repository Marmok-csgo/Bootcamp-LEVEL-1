class Program
{
    static void Main(string[] args)
    {
        var AdminLogin = "MrAke";
        var AdminPassword = "password";

        while (true)
        {
            Console.WriteLine("\t\t\tEnterance");
            Console.Write("Login: ");
            var userLogin = Console.ReadLine();
            Console.Write("Password: ");
            var userPassword = Console.ReadLine();

            if (userLogin == AdminLogin && userPassword == AdminPassword)
            {
                Console.WriteLine("1 - Create Project\t2 - Create Task\t3 - Create Developer\t4 - Send Notification");

            }
        }
    }
}