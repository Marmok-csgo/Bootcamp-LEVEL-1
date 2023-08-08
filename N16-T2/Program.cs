using N16_T2;

class Program
{
    static void Main(string[] args)
    {
        var temp = new TemperatureSensorService();
        temp.Temperature = "20";
        temp.Temperature = "30";
        temp.Temperature = "40";
        temp.Temperature = "-10";
        temp.Temperature = "-20";

        temp.DisplayAll();


    }
}