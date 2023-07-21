var events = new[]
{
    "O'qituvchi va murabbiylar Kuni",
    "O'zbekiston Konstitutsiya Kuni",
    "O'zbekiston Mustaqillik Kuni",
    "Otalar kuni",
    "Yoshlar Kuni",
};

var times = new[]
{
    new DateTime(2023, 9, 1, 12, 30, 0),
    new DateTime(2023, 12, 8, 9, 0, 0),
    new DateTime(2023, 10, 1, 10, 50, 0),
    new DateTime(2023, 9, 11, 7, 30, 0),
    new DateTime(2023, 12, 12, 16, 0, 0)
};

var counties = new[] { "en", "uz", "ru" };

//Sorting
for (var i = 0; i < events.Length; i++)
{
    for (var j = i + 1; j < events.Length; j++)
    {
        if (times[i] < times[j])
        {
            var temp = times[i];
            times[i] = times[j];
            times[j] = temp;

            var temp2 = events[i];
            events[i] = events[j];
            events[j] = temp2;
        }
    }
}

foreach (var c in counties)
{
    Console.WriteLine(c);
    if (c == "en")
    {
        for (var i = 0; i < events.Length; i++)
        {
            Console.WriteLine($" - {events[i]} - {times[i].ToString("dd.MM.yyyy hh:mm tt")}");
        }
    }
    else if (c == "ru")
    {
        for (var i = 0; i < events.Length; i++)
        {
            Console.WriteLine($" - {events[i]} - {times[i].ToString("dd/MM/yyyy HH:mm")}");
        }
    }
    else if (c == "uz")
    {
        for (var i = 0; i < events.Length; i++)
        {
            Console.WriteLine($" - {events[i]} - {times[i].ToString("dd.MM.yyyy HH:mm")}");
        }
    }

}