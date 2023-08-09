using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N13_T1
{
    public class OptimizedGameEngine : GameEngine
    {
        public OptimizedGameEngine()
        {
            HeroList.Add(new Hero("Invoker"));
            HeroList.Add(new Hero("Lina"));
            HeroList.Add(new Hero("Medusa"));

            DisplayHeroes();
        }
    }
}
