using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N13_T4;

    public class HardQuestion
    {
        
        StandartQuestion Standartquestion = new StandartQuestion();
        
        Dictionary<string, string> HardQueDict = new Dictionary<string, string>()
        {
            {"Which country is home to the world's largest coral reef system?" , "Australia"},
            { "What is the deepest oceanic trench in the world?" , "Mariana"},
            {"Name the active volcano in Italy that famously erupted in AD 79, burying the city of Pompeii." , "Mount Vesuvius" }

        };

        public void HardQuestions()
        {
            var countFalse = 0;
            var countTrue = 0;
            for (int i = 0; i < HardQueDict.Count; i++)
            {
                Random rand = new Random();

                int randomIndex = rand.Next(0, 3);
                var randomEntry = HardQueDict.ElementAt(randomIndex);
                var randomValueKey = randomEntry.Key;
                var randomValueValue = randomEntry.Value;

                Console.WriteLine($"Hard Question:{randomValueKey}");
                string? UserAnswer = Console.ReadLine();


                countFalse += (UserAnswer != randomValueValue) ? 1 : 0;
                countTrue += (UserAnswer == randomValueValue) ? 1 : 0;



                if (countFalse == 2)
                {
                    Standartquestion.StandartQuestions();
                }





            }
        }
    }
