
List<string> userNames = new List<string>{"MarmokCsgo", "AkeTostoboy", "NeverGiveUp", "Abdura24"};

var createFileTasks = userNames.Select(user => Task.Run(() =>
{
    return File.Create($"{user.ToLower()}.docx");
}));

foreach (var task in createFileTasks)
{
    Console.WriteLine($"{task} uchun file yaratildi.");
}

var userFiles = await Task.WhenAll(createFileTasks);