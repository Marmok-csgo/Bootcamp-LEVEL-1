public class Program
{
    static void Main(string[] args)
    {
        string[] Names = new string[]
        {
            "Peter Michael Brown",
            "John David Smith",
            "John Johns Jones",
            "G`ishtmat G`ishtmatov G`ishtmatovich"
        };


        Console.Write("Search: ");
        var searchName = Console.ReadLine();

        foreach (var name in Names)
        {
            if (name.Contains(searchName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(name);
            }
        }
    }
}