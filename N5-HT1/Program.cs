string[] test = {
    "What is alternative for else-if ?",
    "Give 2 examples of the searching attribute.",
    "What is the default value for boolean ?",
    "what attribute we use to separate the string ?",
    "What is 2+2*2 ?"
    };

string[] trueAnswers = {
    "Switch case",
    "indexof, contains",
    "false",
    "split",
    "6"
};

string[] falseAnswers = {
    "Switch Expression",
    "Search, Find",
    "true",
    "join",
    "8"
};

List<string> userAnswers = new List<string>();
var score = 0;


for (int i = 0; i < test.Length; i++)
{
    Console.Clear();
    Console.WriteLine($"Question_{i + 1}:{test[i]}");
    Console.WriteLine($"A){trueAnswers[i]}");
    Console.WriteLine($"B){falseAnswers[i]}\n");
    Console.Write("User:");
    var user = Convert.ToString(Console.ReadLine()).ToUpper();
    if ( user == "A")
    {
        score += 20;
    }
    else if ( user == "B")
    {
        userAnswers.Add(test[i]);
    }
    else
    {
        userAnswers.Add(test[i]);
    }

}

Console.Clear();
Console.WriteLine($"Score: {score}");
if (userAnswers.Count == 0)
{
    Console.WriteLine("You are Genious!");
}
else {
    Console.WriteLine("\t\t\t\t\tInvalid Answers:\n");
    foreach (string answer in userAnswers)
    {
        int index = Array.IndexOf(test, answer);
        Console.WriteLine($"Question_{index + 1}:{test[index]}\n" +
            $"Answer:{trueAnswers[index]}");

    }
}