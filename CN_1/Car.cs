namespace CN_1;

public class Car
{
    private Engine carEngine = new Engine();

    public void StartCar()
    {
        carEngine.Start();
        Console.WriteLine("Car started");
    }
    
    public void StopCar()
    {
        carEngine.Stop();
        Console.WriteLine("Car stopped");
    }
}