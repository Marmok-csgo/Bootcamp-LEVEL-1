using Newtonsoft.Json;
namespace LowLevelTaskManagement;

class PRogram
{
    static void Main()
    {
        var filePath = @"D:\project\Bootcamp-LEVEL-1\LowLevelTaskManagement\TaskManagement.txt";

        var ser = new TaskService();
        
        ser.AddTask(new Task(1, Priority.Low, DateTime.Now.AddDays(2)));
        ser.AddTask(new Task(2, Priority.Medium, DateTime.Now.AddDays(4)));
        ser.AddTask(new Task(3, Priority.High, DateTime.Now.AddDays(3)));

        // var jSon = JsonConvert.SerializeObject(ser.GetT(), Formatting.Indented);
        //
        // File.WriteAllText(filePath, jSon);


        var source = File.ReadAllText(filePath);
        Console.WriteLine(source);
    }
}


