using N13_HT1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N13_HT1
{
    public class Animal
    {



        public void MakeSound()
        {
            Console.WriteLine("....");
        }
    }
}


class Bird : Animal
{

    public void Fly()
    {
        Console.WriteLine("Fly");
    }


}


class Mammal : Animal
{
    public void Run()
    {
        Console.WriteLine("Run");
    }

}

class Fish : Animal
{
    public void Swim()
    {
        Console.WriteLine("Swim");
    }

}

class Sparrow : Bird
{

}

class Tiger : Mammal
{

}

class GreatWhiteShark : Fish
{

}


