
string[] usernames = { "aziz-yorar", "rustam-kachok", "umar-doter", "aziz-ake" };
var list = new List<string> { "yorar", "ake", "doter", "krisa", "gamer", "vlog", "kachok" };

var res = "";
Console.Write("Enter name: ");
var name = Console.ReadLine();
var check = true;


while (check)
{
    var random = new Random();
    int index = random.Next(list.Count);
    res += $"{name}-{list[index]}";
    foreach (var item in usernames)
    {
        if (res == item)
        {
            continue;
        }
        else
        {
            Console.WriteLine(res);
            check = false;
            break;

        }
    }
}