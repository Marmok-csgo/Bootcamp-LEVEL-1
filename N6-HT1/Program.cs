using static System.Formats.Asn1.AsnWriter;

string[] names = new string[10]
{
    "Firdavs",
    "Umar",
    "Doston",
    "Sardor",
    "Behruz",
    "Aziz",
    "Hushnud",
    "Ali",
    "Usmon",
    "Hafiz"
};

int[] scores = new int[10]
{
    95,
    81,
    85,
    72,
    76,
    99,
    54,
    66,
    55,
    87
};
var countGreater80 = 0;
var countGreater90 = 0;

int maxScore = scores.Max();
int normalScore = scores.Sum() / scores.Length;
int minScore = scores.Min();

foreach (var score in scores)
{
    if(score > 80 && score < 90)
    {
        countGreater80++;
    }
    if(score > 90)
    {
        countGreater90++;
    }
}

for (int i = 0; i < scores.Length; i++)
{
    for (int j = i + 1; j < scores.Length; j++)
    {
        if (scores[i] > scores[j])
        {
            var temp = scores[i];
            scores[i] = scores[j];
            scores[j] = temp;

            var tempStr = names[i];
            names[i] = names[j];
            names[j] = tempStr;
        }
    }
}

Console.WriteLine($"Maximum score: {maxScore}.\n" +
    $"Normal score: {normalScore}.\n" +
    $"Minimum score: {minScore}.\n\n" +
    $"Number of students who scored higher than 80 - {countGreater80}.\n" +
    $"Number of students who scored higher than 90 - {countGreater90}.\n");

for (int i = 0; i < scores.Length; i++)
{
    if (scores[i] > 90)
    {
        Console.WriteLine($"{names[i]} - Top - {scores[i]}");
    }
    else if (scores[i] > 80 && scores[i] < 90)
    {
        Console.WriteLine($"{names[i]} - Good - {scores[i]}");
    }
    else
    {
        Console.WriteLine($"{names[i]} - Fail - {scores[i]}");
    }
}