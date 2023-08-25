

using EmailAsync;
// Console.WriteLine("Enter the email address: ");
// var userEmail = Console.ReadLine();
// var emailservice = new EmailService();


var userNames = new List<string> { "Thor", "Tony", "Steve", "Clint" };

// foreach (var email in userNames)
// {
//     Console.WriteLine(email);
//     // var result = Task.Run(() =>
//     // {
//         Thread.Sleep(3000);
//         Console.WriteLine(10);
//     // });
//     
//     Console.WriteLine("Task completed.");
// }



var createFileTasks = userNames.Select(user => Task.Run(() =>
{
    return File.Create($"{user.ToLower()}.docx");
}));

foreach (var item in createFileTasks)
{
    Console.WriteLine(item);
}


var userFiles = await Task.WhenAll(createFileTasks);

    
    
    
    




























