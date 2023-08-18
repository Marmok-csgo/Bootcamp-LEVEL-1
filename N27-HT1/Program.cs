namespace N27_HT1;

class Program
{
    static void Main()
    {
        var userService = new UserService();
        userService.Add("aketostoboy@gmail.com", "qWert_12354");
        userService.Add("ferferrolaniajali@gmail.com", "Qkig*@671rd");

        var Result = userService.GetUsers();

        foreach (var user in Result)
        {
            if (user.IsAdmin == true)
                Console.WriteLine($"Admin: {user.EmailAddress}");

            else
            {
                Console.WriteLine($"{user.EmailAddress}");
            }
        }

    }
}