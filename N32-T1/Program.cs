namespace N32_T1;

class Program
{
    static void Main()
    {
        var link1 = new ShortenedLink(1, "https://example.com/page2", "https://short.link/def");
        var link2 = new ShortenedLink(1, "test.com/page3", "short.link/test");
        
        Console.WriteLine(link1.Equals(link2));
    }
}