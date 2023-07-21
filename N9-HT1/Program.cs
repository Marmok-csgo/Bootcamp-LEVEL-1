using System.Text.RegularExpressions;

string[] emails = { 
    "test@gmail.com",
    "t.com",
    "ake@gmail.com",
    "ake__123@gmail.com",
    "tele@@gmail.com"
};

string pattern = @"^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+$";
var reGex = new Regex(pattern);

foreach (string email in emails)
{
    if (reGex.IsMatch(email))
    {
        Console.WriteLine($"{email} - Valid.");
    }
    else
    {
        Console.WriteLine($"{email} - inValid."); 
    }
}