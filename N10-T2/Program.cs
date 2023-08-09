Random random = new Random();
int randomNumber = random.Next(1, 11);
var check = true;

while (check)
{
    Console.Write($"Guess number from 1 to 10: ");
    string guessedNum = Console.ReadLine();
    try
    {
        Console.Clear();
        if (!int.TryParse(guessedNum, out int result))
        {
            throw new FormatException("Not a number!");
        }
        if (Convert.ToInt32(guessedNum) != randomNumber)
        {
            throw new ArgumentOutOfRangeException("You Couldn't guessed it!");
        }
        else
        {
            Console.WriteLine("Congrats! You Guessed it");
            check = false;
        }

    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (FormatException ex)
    {
        Console.WriteLine(ex.Message);
    }
}