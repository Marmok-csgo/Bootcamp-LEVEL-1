using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N18_T1
{
    public class Mustang : Car
    {
        public static int Passangers = 5;
        public readonly int MaxSpeed;

        public Mustang(string brand, int year, string color, int maxspeed)
        {
            Brand = brand;
            Year = year;
            Color = color;
            MaxSpeed = maxspeed;
        }

        public override void Show()
        {
            Console.WriteLine($"Brand: {Brand}, Year: {Year}, Color: {Color}, MaxSpeed: {MaxSpeed}, Passangers: {Passangers}");
        }

        public override void Drive()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var random = new Random();
            int startSpeed = 0;
            int endSpeed = 100;
            while ( startSpeed <= endSpeed - 1 )
            {
                Thread.Sleep(500);
                startSpeed = random.Next(startSpeed, endSpeed + 1);
            }
            stopwatch.Stop();
            TimeSpan elapsedTime = stopwatch.Elapsed;

            Console.WriteLine($"{Brand} - {elapsedTime}");
        }
    }
}
