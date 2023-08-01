using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N16_HT1
{
    public class Spaceship
    {
        public string Name { get; init; }

        public string Fuel { get; }
        public int Speed { get; set; }
        
        private string _trajectory;
        public string Trajectory
        {
            set => _trajectory = value;
        }

        public override string ToString()
        {
            return $"{Name}'s speed is {Speed}.{_trajectory}";
        }
    }
}
