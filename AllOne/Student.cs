using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllOne
{
    internal class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDay { get; set; }
        public decimal Payment { get; set; }
        public string EduType { get; set; }
        public int PaymentAmount { get; set; }

        public int getAge() => DateTime.Now.Year - BirthDay.Year;

        public string shortName()
        {
            string[] substrings = FullName.Split();
            return $"{substrings[0]} {substrings[1]}";
        }
         
        public string GetAmount()
        {
            decimal amount = Payment - PaymentAmount;
            if (amount > 0) return $"{amount} haqdor";
            else return $"{-amount} qarzdor";
        }

        public static void AddStudent(List<Student> students)
        {
            Console.Clear();
            Console.Write("FIO: ");
            string FIO = Console.ReadLine();

            Console.Write("Yunalish: ");
            string EdutYpe = Console.ReadLine();

            students.Add(new Student
            {
                Id = students.Last().Id + 1,
                FullName = FIO,
                BirthDay = DateTime.Now,
                EduType = EdutYpe
            });
        }

        public static void RemoveStudent(List<Student> students)
        {
            Console.Clear();
            Console.Write("Enter index:");
            int indexToRemove = Convert.ToInt32(Console.ReadLine());
            students.RemoveAt(indexToRemove-1);
        }


        public static void SectionThree(List<Student> student, int[,] balls)
        {
            Console.Clear();
            Console.WriteLine($"\tNames\t  |  10-may  | \t |  11-may  | \t |  12-may  | \t |  13-may  |\n");
            for (int i = 0; i < balls.Length; i++)
            {
                Console.Write($"{student[i].shortName()}");

                for (int j = 0; j < 4; j++)
                {
                    Console.Write(" \t" + balls[i, j] + "%\t");
                }
                Console.WriteLine("\n");
            }
        }

        public static void SectionTwo(List<Student> student)
        {
            Console.Clear();
            foreach (var item in student)
            {
                Console.WriteLine($"{item.shortName().PadRight(35, ' ')} {item.GetAmount()}");
            }
        }

        public static void SectionOne(List<Student> student)
        {
                    Console.Clear();
        Console.WriteLine($"1 - dotnet students\t" +
            $"2 - Dizayn students\t" +
            $"3 - Python students\t" +
            $"4 - SMM students\t" +
            $"0 - back");
        Console.Write("Choose one class: ");
        var classes = Console.ReadLine();

        switch (classes)
        {
            case "1":
                Console.Clear();
                foreach (var item in student)
                {
                    if (item.EduType == "DotNET")
                    {
                        Console.WriteLine($"{item.Id} - {item.shortName()} - {item.getAge()} - {item.EduType}");

                    }
                }
                break;
            case "2":
                Console.Clear();
                foreach (var item in student)
                {
                    if (item.EduType == "Dizayn")
                    {
                        Console.WriteLine($"{item.Id} - {item.shortName()} - {item.getAge()} - {item.EduType}");

                    }
                }
                break;
            case "3":
                Console.Clear();
                foreach (var item in student)
                {
                    if (item.EduType == "Python")
                    {
                        Console.WriteLine($"{item.Id} - {item.shortName()} - {item.getAge()} - {item.EduType}");

                    }
                }
                break;
            case "4":
                Console.Clear();
                foreach (var item in student)
                {
                    if (item.EduType == "SMM")
                    {
                        Console.WriteLine($"{item.Id} - {item.shortName()} - {item.getAge()} - {item.EduType}");

                    }
                }
                break;
        }
        }
    }
}

