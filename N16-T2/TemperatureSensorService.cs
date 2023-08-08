using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N16_T2
{
    internal class TemperatureSensorService
    {
        private List<string> TemperatureList = new List<string>();
        private string _temperature;
        public string Temperature
        {
            set
            {
                TemperatureList.Add(value);
                _temperature = value;
            }
        }



        public void DisplayAll()
        {
            if(TemperatureList.Count  == 0)
            {
                Console.WriteLine("List is Empty!");
            }

            foreach(string value in TemperatureList)
            {
                Console.WriteLine(value);
            }


        }
    }
}
