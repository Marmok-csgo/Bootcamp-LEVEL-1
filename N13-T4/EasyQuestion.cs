using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N13_T4 
{
    public class EasyQuestion
    {

        StandartQuestion StandartQuestion = new StandartQuestion();
        Dictionary<string, string> EasyQueDict = new Dictionary<string, string>()
        {
            {"Name the largest island in the world" , "Greenland"},
            {"What is the largest lake by surface area in Africa?" , "Victoria" },
            {"Name the smallest country in the world by land area." , "Vatican" }
        };

        public void EasyQuestions()
        {
            var countFalse = 0;
            var countTrue = 0;
            for (int i = 0; i < EasyQueDict.Count; i++)
            {
                Random rand = new Random();

                int randomIndex = rand.Next(0, 3);
                var randomEntry = EasyQueDict.ElementAt(randomIndex);
                var randomValueKey = randomEntry.Key;
                var randomValueValue = randomEntry.Value;

                Console.WriteLine($"Easy Question:{randomValueKey}");
                string? UserAnswer = Console.ReadLine();


                countFalse += (UserAnswer != randomValueValue) ? 1 : 0;
                countTrue += (UserAnswer == randomValueValue) ? 1 : 0;

                if (countTrue == 2)
                {
                    StandartQuestion.StandartQuestions();
                }
            }
        }
    }
}
