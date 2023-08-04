using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Car> cars = new List<Car>
        {
            new Car("Accord", "Honda"),
            new Car("Camry", "Toyota"),
            new Car("Civic", "Honda"),
            new Car("Accord", "Honda"),
            new Car("Elantra", "Hyundai"),
            new Car("Sonata", "Hyundai"),
            new Car("Elantra", "Hyundai"),
            new Car("Fusion", "Ford"),
            new Car("Accord", "Honda"),
            new Car("Malibu", "Chevrolet")
        };

        Dictionary<Car, int> carCount = new Dictionary<Car, int>();

        foreach (Car car in cars)
        {
            if (carCount.ContainsKey(car))
                carCount[car]++;
            else
                carCount.Add(car, 1);
        }

        foreach (var entry in carCount)
        {

            if(entry.Value > 1)
            {
                Console.WriteLine($"{entry.Key.Make} {entry.Key.Model}: {entry.Value}");

            }
        }
    }
}
