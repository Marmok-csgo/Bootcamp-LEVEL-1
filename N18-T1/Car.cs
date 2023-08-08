using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N18_T1
{
    public abstract class Car
    {
        public string Brand { get; init; }
        public int Year { get; init; }
        public string Color { get; set; }

        public abstract void Show();

        public abstract void Drive();
    }

}
