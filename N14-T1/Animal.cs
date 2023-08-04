using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N14_T1
{
    public class Animal
    {


        public virtual void FunFact()
        {
            Console.WriteLine("...");
        }

    }

    public class Dalmatian : Animal
    {
        public override void FunFact()
        {
            Console.WriteLine("Dalmatians are born without spots!");
        }

    }


    public class Cat : Animal
    {
        public override void FunFact()
        {
            Console.WriteLine("Cats have 32 muscles in each ear.");
        }
    }


    public class Starfish : Animal
    {
        public override void FunFact()
        {
            Console.WriteLine("Starfish do not have a brain.");
        }
    }
}
