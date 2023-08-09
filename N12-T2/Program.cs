using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<User> queue = new Queue<User>();

        queue.Enqueue(new User("Peter", "Michael", "Brown"));
        queue.Enqueue(new User("John", "David", "Smith"));
        queue.Enqueue(new User("Mary", "Anne", "Jones"));
        queue.Enqueue(new User("G`ishtmat", "G`ishtmatov", "G`ishtmatovich"));

        while (true)
        {
            Console.Write("Ismingizni kiriting: ");
            string Name = Console.ReadLine();

            Console.Write("Sharifingizni kiriting: ");
            string Fname = Console.ReadLine();

            Console.Write("Familyangizni kiriting: ");
            string Surname = Console.ReadLine();


            User currentUser = new User(Name, Fname, Surname);

            if (queue.Contains(currentUser))
            {
                Console.WriteLine($"{Name}, uje navbatda sanku!");
            }
            else
            {
                queue.Enqueue(currentUser);
                Console.WriteLine($"Navbatdagi foydalanuvchilar:");
                foreach (User user in queue)
                {
                    Console.WriteLine($"{user.FirstName} {user.MiddleName} {user.LastName}");
                }
            }
        }
    }
}