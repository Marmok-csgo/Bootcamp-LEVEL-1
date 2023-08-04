using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Enter a age: ");
        string userAge = Console.ReadLine();
        Console.Write("Enter a first name: ");
        string FirstName = Console.ReadLine();
        Console.Write("Enter a last name: ");
        string LastName = Console.ReadLine();
        Console.Write("Enter an email: ");
        string UserEmail = Console.ReadLine();
        Console.Write("Enter a number: ");
        string UserPhoneNumber = Console.ReadLine();

        Validator validator = new Validator();
        bool result1 = validator.IsValidAge(userAge);
        bool result2 = validator.IsValidName(FirstName);
        bool result3 = validator.IsValidName(LastName);
        bool result4 = validator.IsValidEmailAddress(UserEmail);
        bool result5 = validator.IsValidPhoneNumber(UserPhoneNumber);

        Console.WriteLine($"{userAge} - {result1}\n" +
            $"{FirstName} - {result2}\n" +
            $"{LastName} - {result3}\n" +
            $"{UserEmail} - {result4}\n" +
            $"{UserPhoneNumber} - {result5}");

    }
}



class Validator
{
    public bool IsValidAge(string age)
    {
        if (int.TryParse(age, out int number))
        {
            return true;
        }
        else
        {
            return false; 
        }
    }

    public bool IsValidName(string lastFirstName)
    {
        if (string.IsNullOrEmpty(lastFirstName))
        {
           return false;
        }

        if (lastFirstName.Trim().Length == 0)
        {
           return false;
        }

        foreach (char c in lastFirstName)
        {
           if (char.IsDigit(c))
           {
               return false;
           }
        }
        return true;
    }

    public bool IsValidEmailAddress(string emailAddress)
    {
        string pattern = @"^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+$";
        var reGex = new Regex(pattern);

        return reGex.IsMatch(emailAddress);
            
    }

    public bool IsValidPhoneNumber(string phoneNumber)
    {
        string pattern = @"^\+998\s\d{2}-\d{3}-\d{2}-\d{2}$";

        Regex regex = new Regex(pattern);

        return regex.IsMatch(phoneNumber);
    }
}