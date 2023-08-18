namespace N27_T1;

class Program
{
    static void Main(string[] args)
    {
        var person1 = new Person{login = "John", age = 30, email = "John@example.com"};
        var person2 = new Person{login = "Alice", age =25, email = "Alice@example.com"};
        
        var dbContext = new EFCoreContext();
        
        dbContext.People.Add(person1);
        dbContext.People.Add(person2);
        dbContext.SaveChanges();
    }
}