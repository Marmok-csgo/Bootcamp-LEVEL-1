using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> films = new List<string>
        {
            "Inception",
            "Dark Knight",
            "Top Gun 2",
            "Don't Look Up",
            "Top Gun"
        };

        Console.WriteLine("O'sish bo'yicha:");
        films.Sort(); 
        PrintList(films);

        Console.WriteLine("\nKamayish bo'yicha:");
        films.Reverse();
        PrintList(films);
    }

    static void PrintList(List<string> list)
    {
        foreach (string item in list)
        {
            Console.WriteLine(item);
        }
    }
}
