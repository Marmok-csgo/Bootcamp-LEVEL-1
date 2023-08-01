class Program
{
    static void Main(string[] args)
    {
        SmartHomeService smartHome = new SmartHomeService("MyHome");
        smartHome.Activate();

        smartHome.ExpectedTemperature = 20;
        smartHome.SetCurrentTemperature(22);
        smartHome.DisplayHomeTemperature();

        smartHome.ExpectedTemperature = 20;
        smartHome.SetCurrentTemperature(23);
        smartHome.DisplayHomeTemperature();

        smartHome.ExpectedTemperature = 20;
        smartHome.SetCurrentTemperature(21);
        smartHome.DisplayHomeTemperature();

        smartHome.ExpectedTemperature = 20;
        smartHome.SetCurrentTemperature(20);
        smartHome.DisplayHomeTemperature();

        smartHome.ExpectedTemperature = 25;
        smartHome.SetCurrentTemperature(21);
        smartHome.DisplayHomeTemperature();

        smartHome.ExpectedTemperature = 25;
        smartHome.SetCurrentTemperature(22);
        smartHome.DisplayHomeTemperature();

        smartHome.ExpectedTemperature = 25;
        smartHome.SetCurrentTemperature(23);
        smartHome.DisplayHomeTemperature();

    }
}