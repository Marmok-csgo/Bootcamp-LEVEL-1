Console.Write("day: ");
int day = Convert.ToInt32(Console.ReadLine());
Console.Write("month: ");
int month = Convert.ToInt32(Console.ReadLine());
Console.Write("year: ");
int year = Convert.ToInt32(Console.ReadLine());

DateTime date = new DateTime(year, month, day);

while (true)
{
    Console.Clear();
    DateTime now = DateTime.Now;
    Console.WriteLine($"{Math.Abs(now.Year - date.Year)} yil/" +
                      $"{Math.Abs(now.Month - date.Month)} oy/" +
                      $"{Math.Abs(now.Day - date.Day)} kun/" +
                      $"{Math.Abs(now.Hour - date.Hour)} soat/" +
                      $"{Math.Abs(now.Minute - date.Minute)} min/" +
                      $"{Math.Abs(now.Second - date.Second)} sec/");
    Thread.Sleep(1000);
}