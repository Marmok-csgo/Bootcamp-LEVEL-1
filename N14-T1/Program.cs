using N14_T1;

class program
{
    static void Main(string[] args)
    {
        Animal animal = new Animal();
        animal.FunFact();

        Animal Dog = new Dalmatian();
        Dog.FunFact();

        Animal Cat = new Cat();
        Cat.FunFact();

        Animal Fish = new Starfish();
        Fish.FunFact();
    }
}