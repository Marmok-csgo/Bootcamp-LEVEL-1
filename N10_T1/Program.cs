Console.Write("Enter a first name: ");
var firstName = Console.ReadLine();
Console.Write("Enter a last name: ");
var lastName = Console.ReadLine();
Console.Write("Enter a age: ");
var age = Convert.ToInt32(Console.ReadLine());

var user = new User(firstName, lastName, age);

Console.WriteLine($"{user.FirstName} - {user.LastName} - {user.Age}");

class User
{

    public User(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

}


