using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumtionPer1Km = double.Parse(input[2]);
                Car car = new Car(model, fuelAmount, fuelConsumtionPer1Km);
                cars.Add(car);
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                //"Drive {carModel} {amountOfKm}"
                string[] cmdArgs = command.Split();
                string carModel = cmdArgs[1];
                double amountOfKm = double.Parse(cmdArgs[2]);

                cars.First(x => x.Model == carModel).Drive(cars.First(x => x.Model == carModel), amountOfKm);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.Fuel:f2} {car.TravelledDistance}");
            }
        }
    }
}
