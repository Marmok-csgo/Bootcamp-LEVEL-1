using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N13_T1
{
    public class GameEngine
    {
        public List<Hero> HeroList = new List<Hero>()
        {
            new Hero("Yurnero"),
            new Hero("Sven"),
            new Hero("Tiny")
        };

        public void DisplayHeroes()
        {
            foreach (var hero in HeroList)
            {
                Console.WriteLine(hero.ToString());
            }
        }
    }

}
