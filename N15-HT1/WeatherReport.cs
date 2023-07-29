using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N15_HT1
{
    public class WeatherReport
    {
        protected Dictionary<DateTime, string> WeatherDict = new Dictionary<DateTime, string>();
        protected List<DateTime> ForSortedLists = new List<DateTime>();

        public string Get(DateTime date)
        {
            return Find(date) == null ? "Berilgan kundagi obhavo topilmadi, boshqa kunlar uchun foydalanib kuring" : Find(date);
        }





        private string Find(DateTime date)
        {
            foreach (var item in WeatherDict)
            {
                if (date == item.Key)
                {
                    return $"{item.Key} - {item.Value}";
                }
            }
            return null;
            
        }

        public virtual void Add(DateTime date, string weatherName)
        {
            WeatherDict.Add(date, weatherName);
        }
    }
}
