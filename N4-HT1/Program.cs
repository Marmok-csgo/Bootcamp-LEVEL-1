using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

var startScore = 100;
var Essay = "Lorem ipsum dolor sit amet consectetur adipisicing" +
    " elit.quaerat est quas commodi quibusdam labore, nihil doloribus " +
    "quam temporibus inventore optio expedita consectetur voluptatem " +
    "QUIDEM nulla soluta earum.Numquam rem alias minima culpa iste " +
    "distinctio.Eum similique est consequuntur minus, odio nisi recusandae " +
    "iure asperiores facere, reiciendis voluptate maiores! Repellat, dolorum!";

var allSentences = Essay.Length;   //386
string[] Sentence = Essay.Split(".");
string[] words = Essay.Split();
double percentage = 20;
var result = Convert.ToInt32(allSentences * (percentage / 100));

if (Essay.Length < 500)
{
    startScore -= 5;

}

foreach (string word in Sentence)
{
    if (word[0].ToString() != word[0].ToString().ToUpper())
    {
        startScore -= 5;
    }
}

foreach (string sentens in words)
{
    int count = Regex.Matches(Essay, $@"\b{sentens}\b").Count;
    if (count >= result)
    {
        startScore -= 5;
    }
    if(sentens.Length > 20)
    {
        startScore -= 5;
    }
    if (Char.IsUpper(sentens[0]) && sentens.Skip(1).All(Char.IsLower))
    {
        startScore -= 10;
    }
    if (sentens.Length > 20)
    {
        startScore -= 20;
    }
}

Console.WriteLine($"Result: {startScore}");
