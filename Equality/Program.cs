using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<string> group1 = new HashSet<string> { "John", "Tom", "Tim" };

        HashSet<string> group2 = new HashSet<string> { "John", "Tim", "Tom" };
        bool areEqual = group1.SetEquals(group2);

        Console.WriteLine(areEqual); 
    }
}
