using System;

class Program
{
    static void Main()
    {
        User user1 = new User("John Doe");
        User user2 = new User("John Doe");

        Console.WriteLine("user1 == user2 ? " + user1.Equals(user2));
    }
}
