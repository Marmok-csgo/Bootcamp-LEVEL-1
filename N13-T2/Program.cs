using N13_T2;

class Program
{
    static void Main(string[] args)
    {
        EventManager eventManager = new EventManager();
        eventManager.Add("Gaming", new DateOnly(2023,7,27));
        eventManager.Add("Meeting", new DateOnly(2023,7,28));
        eventManager.Add("Tournament", new DateOnly(2023,7,29));

        eventManager.Add("Breakfast", new TimeOnly(12, 30, 45));
        eventManager.Add("Lunch", new TimeOnly(18, 30, 45));
        eventManager.Add("SLeep", new TimeOnly(21, 00, 00));


        eventManager.Display();

    }
}