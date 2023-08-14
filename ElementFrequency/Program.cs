using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> yoshlar = new List<int> { 12, 15, 25, 12, 56, 13, 81, 55, 25, 12 };

        Dictionary<int, int> yoshlarSoni = new Dictionary<int, int>();

        foreach (int yosh in yoshlar)
        {
            if (yoshlarSoni.ContainsKey(yosh))
            {
                yoshlarSoni[yosh]++;
            }
            else
            {
                yoshlarSoni[yosh] = 1;
            }
        }

        foreach (var pair in yoshlarSoni)
        {
            if(pair.Value > 1)
            {
                Console.WriteLine(pair.Key + " - " + pair.Value);

            }

        }
    }
}
