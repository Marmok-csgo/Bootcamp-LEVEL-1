public class Temperature
{
    public int CurrentTemperature { get; set; }
    public int ExpectedTemperature { get; set; }
}

public class SmartHomeService
{
    private bool IsActivated { get; set; }
    private readonly string DeviceName;
    private Temperature temperature;

    public SmartHomeService(string deviceName)
    {
        DeviceName = deviceName;
        IsActivated = false;
        temperature = new Temperature();
    }

    public void Activate()
    {
        IsActivated = true;
    }

    public void SetCurrentTemperature(int currentTemperature)
    {
        if (IsActivated)
        {
            temperature.CurrentTemperature = currentTemperature;
        }
        else
        {
            Console.WriteLine("SmartHomeService is not activated yet. Please activate it first.");
        }
    }

    public int ExpectedTemperature
    {
        get { return temperature.ExpectedTemperature; }
        set
        {
            temperature.ExpectedTemperature = value;
        }
    }

    public void DisplayHomeTemperature()
    {
        Console.WriteLine($"Expected - {temperature.ExpectedTemperature}, Current - {temperature.CurrentTemperature}");
    }
}

