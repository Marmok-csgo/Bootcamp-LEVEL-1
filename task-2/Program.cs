var str = "nAJMIDDIN nAJMIDDINOV nAJMIDDINOVICH";
string[] mas = str.Split();
for (int i = 0; i < mas.Length; i++)
{
    Console.WriteLine(mas[i][0].ToString().ToUpper() + mas[i].Substring(1).ToLower());
}