using N19_T1;

class Program
{
    static void Main(string[] args)
    {
        var person1 = new Person();
        person1.Display();


        var person2 = new Person("Alice", 25, "USA");
        person2.Display();

        var person3 = new Person(person2);
        person3.Display();
    }
}