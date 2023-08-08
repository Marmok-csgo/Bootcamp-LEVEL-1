using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N13_T2
{
    public class EventManager
    {
        Dictionary<string, DateOnly> EventDayDict = new Dictionary<string, DateOnly>();
        Dictionary<string, TimeOnly> EventTimeDict = new Dictionary<string, TimeOnly>();

        public void Add(string Datename, DateOnly dateOnly)
        {
            EventDayDict.Add(Datename, dateOnly);
        }



        public void Add(string TimeName, TimeOnly timeOnly)
        {
            EventTimeDict.Add(TimeName, timeOnly);
        }

        public void Display()
        {
            foreach (var item2 in EventTimeDict)
            {
                Console.WriteLine($"{item2.Key} - {item2.Value}");

            }

            foreach (var item1 in EventDayDict)
            {
                Console.WriteLine($"{item1.Key} - {item1.Value}");
            }

        }

    }
}
