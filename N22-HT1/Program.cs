namespace N22_HT1;

class Program
{
    static void Main()
    {
        List<int> nums = new List<int>
        {
            59, 13, 55, 7, 27, 89, 4, 67,
            44, 11, 43, 31, 17, 16, 77, 67,
            37, 12, 5, 63, 29, 8, 11, 45,
            4, 67, 21, 3, 49, 31, 77, 23,
        };
        
        nums.OrderDescending().Where(num => IsPrime(num)).ToList().ForEach(Console.WriteLine);
    }


    public static bool IsPrime(int num)
    {
        for (int i = 2; i < Math.Sqrt(num) + 1; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}