using System;
using System.Collections.Generic;
using System.Diagnostics;

public class Program
{
    
    public static void Main()
    {
        Stopwatch sw = Stopwatch.StartNew();
        Console.Write("Enter elements separated by space:");
        string input = Console.ReadLine();

        List<int> myList = new List<int>(Array.ConvertAll(input.Split(' '), int.Parse));

        Dictionary<int, int> countDictionary = new Dictionary<int, int>();

        foreach (int element in myList)
        {
            if (countDictionary.ContainsKey(element))
            {
                countDictionary[element]++;
            }
            else
            {
                countDictionary[element] = 1;
            }
        }

        var all = 0;
        foreach (KeyValuePair<int, int> kvp in countDictionary)
        {
            var count = kvp.Value / 3;
            var item = kvp.Value - count;
            all += kvp.Key * item;
            Console.WriteLine($"{kvp.Key}$ - {kvp.Value} dona - Jami:{kvp.Key * item}$ - Bonus:{count}");
        }
        Console.WriteLine($"All: {all}");

    }

}

