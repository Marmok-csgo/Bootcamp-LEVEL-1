using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N13_T4 
{
    public class StandartQuestion
    {
        EasyQuestion Easyquestion = new EasyQuestion();
        HardQuestion HardQuestion = new HardQuestion();
        Dictionary<string, string> StandartQueDict = new Dictionary<string, string>()
        {
            {"What is the capital city of Australia?" , "Canberra" },
            { "Which river is the longest in South America?" , "Amazon"},
            { "Which continent is known as the Land Down Under?" , "Australia"},
            {"In which continent is the Sahara Desert located?" , "Africa" },
            {"What is the highest mountain in the European Alps?" , "Mont Blanc" }
        };

        public void StandartQuestions()
        {
            var countFalse = 0;
            var countTrue = 0;
            for (int i = 0; i < StandartQueDict.Count; i++)
            {
                Random rand = new Random();

                int randomIndex = rand.Next(0, 5);
                var randomEntry = StandartQueDict.ElementAt(randomIndex);
                var randomValueKey = randomEntry.Key;
                var randomValueValue = randomEntry.Value;

                Console.WriteLine($"Standart Question:{randomValueKey}");
                string? UserAnswer = Console.ReadLine();


                countFalse += (UserAnswer != randomValueValue) ? 1 : 0;
                countTrue += (UserAnswer == randomValueValue) ? 1 : 0;



                if (countFalse == 2)
                {
                    Easyquestion.EasyQuestions();
                }

                else if (countTrue == 2)
                {
                    HardQuestion.HardQuestions();
                }
            }
        }
    }
}
