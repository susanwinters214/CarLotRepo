using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Car
    {
        // Properties
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        // Constructor to initialize properties
        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }

        // Method to make engine noise
        public void MakeEngineNoise(string noise)
        {
            Console.WriteLine($"The {Year} {Make} {Model} makes the following engine noise: {noise}");
        }

        // Method to make honk noise
        public void MakeHonkNoise(string noise)
        {
            Console.WriteLine($"The {Year} {Make} {Model} makes the following honk noise: {noise}");
        }
    }

    class CarLot
    {
        public List<Car> Cars { get; } = new List<Car>();

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }

        public void ListCars()
        {
            foreach (var car in Cars)
            {
                Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a CarLot instance
            CarLot carLot = new CarLot();

            // Instantiate and set properties for three cars using different methods
            Car car1 = new Car(2022, "Toyota", "Camry", "Vroom Vroom", "Beep Beep", true);
            Car car2 = new Car(2019, "Chevrolet", "Cruze", "Purr Purr", "Honk Honk", true);
            Car car3 = new Car(2020, "Ford", "Mustang", "Roar", "Honk", true);
          
            // Add cars to the CarLot
            carLot.AddCar(car1);
            carLot.AddCar(car2);
            carLot.AddCar(car3);

            // Call the engine noise and honk noise methods for each car
            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);

            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);

            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);

            // List the cars in the CarLot
            Console.WriteLine("Cars in the Car Lot:");
            carLot.ListCars();
        }
    }
}
