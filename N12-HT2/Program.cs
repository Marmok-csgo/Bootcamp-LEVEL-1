public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Check with valid values");
        try
        {
            var validMail = new Email();
            validMail.To = "A3A4TOSTOBOY@gmail.com";
            validMail.From = "aketostoboy@mail.ru";
            validMail.Subject = "Brother let's stream together";
            validMail.Content = "I play well though";
            Console.WriteLine(validMail);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("\nCheck with invalid values");
        var invaliMmail = new Email();
        try
        {
            invaliMmail.To = "A3A4TOSTOBOY@.com";
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            invaliMmail.From = "aketostoboy.com";
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            invaliMmail.Subject = " "; 
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            invaliMmail.Content = "Helo";
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }
}