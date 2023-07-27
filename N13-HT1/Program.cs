using N13_HT1;

public class Program
{
    public static void Main()
    {
        Animal genericAnimal = new Animal();
        genericAnimal.MakeSound();

        Bird bird = new Sparrow();
        bird.Fly();

        Mammal tiger = new Tiger();
        tiger.Run();

        Fish shark = new GreatWhiteShark();
        shark.Swim();
    }
}