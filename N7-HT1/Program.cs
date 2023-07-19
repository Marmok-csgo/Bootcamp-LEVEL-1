using System;

namespace SleepQualityCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime[] dates = { new DateTime(2023, 7, 18), new DateTime(2023, 7, 17), new DateTime(2023, 7, 16), new DateTime(2023, 7, 15), new DateTime(2023, 7, 14) };
            double[] durations = { 7, 8, 6, 7, 8 }; 
            int[] awakenings = { 0, 1, 2, 0, 1 }; 
            double[] sleepQualities = new double[5]; 

            for (int i = 0; i < dates.Length; i++)
            {
                double previousDayMissingSleepHours = 8 - durations[i];
                double sleepQuality = (durations[i] - awakenings[i]) / (8 + previousDayMissingSleepHours) * 10;
                sleepQualities[i] = Math.Round(sleepQuality, 2);
            }

            for (int i = 0; i < dates.Length; i++)
            {
                Console.WriteLine($"{dates[i].ToString("dd.MM.yyyy")} - {durations[i]} hours - {sleepQualities[i]} score");
            }
        }
    }
}
