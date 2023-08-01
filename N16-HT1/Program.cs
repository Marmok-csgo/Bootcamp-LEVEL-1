namespace N16_HT1;
class Program
{
    static void Main(string[] args)
    {
        var spaceShip = new Spaceship()
        {
            Name = "Cosmic Horizon",
            Speed = 250_000,
            Trajectory = "Interstellar Traverse"
        };

        Console.WriteLine(spaceShip);
    }
}