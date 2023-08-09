class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Array: ");
        var array =  Console.ReadLine();

        string[] numberArray = array.Split(' ');

        int Max;
        int Min;

        FindMaxMin(numberArray, out Max, out Min);
        Console.WriteLine($"Max: {Max}\n" +
                          $"Min: {Min}");

    }

    static void FindMaxMin(string[] strs, out int max, out int min)
    {
        max = Convert.ToInt32(strs[0]);
        for (int i = 1; i < strs.Length; i++)
        {
            if (Convert.ToInt32(strs[i]) > max)
            {
                max = Convert.ToInt32(strs[i]);
            }
        }

        min = Convert.ToInt32(strs[0]);
        for (int i = 1; i < strs.Length; i++)
        {
            if (Convert.ToInt32(strs[i]) < min)
            {
                min = Convert.ToInt32(strs[i]);
            }
        }

    }
}