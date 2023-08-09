using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N13_T1
{
    public class Hero
    {
        public Guid Id;
        public string Name;

        public Hero(string name)
        {
            Name = name;
            Id = Guid.NewGuid();

        }

        public override string ToString()
        {
            return $"{Id}: {Name}";
        }
    }
}
