string[] name = new string[5];
name[0] = "Firdavs";
name[1] = "Doniyor";
name[2] = "Umar";
name[3] = "Sardor";
name[4] = "Behruz";

List<int> ages = new List<int>();
DateTime date = DateTime.Now;

DateTime[] birthday = new DateTime[5];
birthday[0] = new DateTime(2016, 11, 13);
birthday[1] = new DateTime(2013, 12, 25);
birthday[2] = new DateTime(2018, 1, 7);
birthday[3] = new DateTime(2012, 6, 1);
birthday[4] = new DateTime(2010, 2, 4);

for  (int i = 0; i < 5; i++)
{
    var Count =  date.Year - birthday[i].Year;
    ages.Add(Count);
}

for  (int i = 0;i < 5; i++)
{
    for (int j = i + 1; j < 5; j++)
    {
        if (ages[i] > ages[j])
        {
            var temp = ages[i];
            ages[i] = ages[j];
            ages[j] = temp;
        }
    }
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"{name[i]} - {ages[i]} yil");
}