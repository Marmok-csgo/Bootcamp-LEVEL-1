namespace N32_T3;

class Program
{
    static void Main()
    {
        var prductService = ProductService.Instance;
        
        prductService.Add(1, "Legion_5_Pro", "Black");
        prductService.Add(2, "Legion_5", "White");

        // var clone1 = prductService.Clone(1);
        var clone2 = prductService.Clone(2);
        
        prductService.Display();
    }
}