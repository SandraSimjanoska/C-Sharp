using Class05.Homework;
using System;

class Program
{
    static void RaceCars(Car car1, Car car2)
    {
        double speed1 = car1.CalculateSpeed();
        double speed2 = car2.CalculateSpeed();

        if (speed1 > speed2)
        {
            Console.WriteLine("Car no. 1 was faster.");
        }
        else if (speed2 > speed1)
        {
            Console.WriteLine("Car no. 2 was faster.");
        }
        else
        {
            Console.WriteLine("It's a tie!");
        }
    }

    static void Main(string[] args)
    {
        Driver[] drivers = {
            new Driver("Bob", 0.8),
            new Driver("Angel", 1.2),
            new Driver("Sandra", 1.0),
            new Driver("Filip", 1.1)
        };

        Car[] cars = {
            new Car("Hyundai", 180),
            new Car("Mazda", 200),
            new Car("Ferrari", 300),
            new Car("Porsche", 280)
        };

        Console.WriteLine("Choose a car no.1:");
        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {cars[i].Model}");
        }
        int car1Choice = int.Parse(Console.ReadLine()) - 1;

        Console.WriteLine("Choose Driver:");
        for (int i = 0; i < drivers.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {drivers[i].Name}");
        }
        int driver1Choice = int.Parse(Console.ReadLine()) - 1;

        Console.WriteLine("Choose a car no.2:");
        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {cars[i].Model}");
        }
        int car2Choice = int.Parse(Console.ReadLine()) - 1;

        Console.WriteLine("Choose Driver:");
        for (int i = 0; i < drivers.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {drivers[i].Name}");
        }
        int driver2Choice = int.Parse(Console.ReadLine()) - 1;

        cars[car1Choice].Driver = drivers[driver1Choice];
        cars[car2Choice].Driver = drivers[driver2Choice];

        RaceCars(cars[car1Choice], cars[car2Choice]);
    }
}