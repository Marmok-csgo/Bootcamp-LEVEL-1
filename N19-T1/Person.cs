
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N19_T1
{
    public class Person
    {
        private string Name { get; set; }
        private int Age { get; set; }
        private string City { get; set; }

        public Person()
        {
            Name = "John";
            Age = 19;
            City = "London";
        }


        public Person(string name, int age, string city)
        {
            Name=name;
            Age=age;
            City=city;
        }

        public Person(Person otherPerson)
        {
            Name=otherPerson.Name;
            Age=otherPerson.Age;
            City=otherPerson.City;
        }


        static Person()
        {
            Console.WriteLine("Static class called.");
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, City: {City}");
        }
    }
}
