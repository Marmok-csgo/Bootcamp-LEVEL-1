using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N15_HT1
{
    public class ValidatedWeahterReport : WeatherReport
    {
        public override void Add(DateTime date, string weatherName)
        {
            foreach(var item in WeatherDict)
            {
                if(WeatherDict.ContainsKey(date))
                {
                    WeatherDict[item.Key] = weatherName;
                    return;
                }
            }
            base.Add(date, weatherName);
        }
    }
}
