using N18_T1;

class Program
{
    static void Main(string[] args)
    {
        var mustang = new Mustang("Ford Mustang", 2005, "Dark Blue", 320);
        mustang.Show();

        var supra = new Supra("Toyota GR", 2006, "Dark Black", 340);
        supra.Show();

        supra.Drive();
        mustang.Drive();

        
    }
}