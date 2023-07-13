using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter email: ");
        string email = Console.ReadLine();

        bool hasError = false;
        bool hasUpperCase = false;

        for (int i = 0; i < email.Length; i++)
        {
            char character = email[i];

            if (!Char.IsLetterOrDigit(character) && character != '.' && character != '@')
            {
                Console.WriteLine("error symbol: " + character);
                hasError = true;
            }

            if (Char.IsUpper(character))
            {
                hasUpperCase = true;
            }
        }

        if (hasError)
        {
            Console.WriteLine("This incorrect email.");
        }
        else
        {
            if (hasUpperCase)
            {
                string lowercaseEmail = email.ToLower();
                Console.WriteLine("Correct email: " + lowercaseEmail);
            }
            else
            {
                Console.WriteLine("Correct email: " + email);
            }
        }
    }
}
