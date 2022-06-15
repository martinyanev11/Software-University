using System;
using System.Collections.Generic;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            List<Tire[]> tiresCollection = new List<Tire[]>();

            string input;
            while ((input = Console.ReadLine()) != "No more tires")
            {
                AddTires(tiresCollection, input);
            }

            List<Engine> enginesCollection = new List<Engine>();

            while ((input = Console.ReadLine()) != "Engines done")
            {
                AddEngine(enginesCollection, input);
            }

            List<Car> cars = new List<Car>();

            while ((input = Console.ReadLine()) != "Show special")
            {
                AddCar(cars, input, enginesCollection, tiresCollection);
            }

            foreach (var car in cars)
            {
                if (IsSpecialCar(car))
                {
                    car.Drive(20);
                    Console.WriteLine(car.WhoAmI());
                }
            }
        }

        private static void AddTires(List<Tire[]> tiresCollection, string input)
        {
            string[] cmdArgs = input.Split();

            Tire[] tires = new Tire[4];
            int indexCounter = 0;

            for (int i = 0; i < cmdArgs.Length - 1; i += 2)
            {
                int year = int.Parse(cmdArgs[i]);
                double pressure = double.Parse(cmdArgs[i + 1]);

                tires[indexCounter] = new Tire(year, pressure);
                indexCounter++;
            }
            tiresCollection.Add(tires);
        }

        private static void AddEngine(List<Engine> enginesCollection, string input)
        {
            string[] cmdArgs = input.Split();

            int horsePower = int.Parse(cmdArgs[0]);
            double cubicCapacity = double.Parse(cmdArgs[1]);

            Engine engine = new Engine(horsePower, cubicCapacity);

            enginesCollection.Add(engine);
        }

        private static void AddCar(List<Car> cars, string input, 
            List<Engine> enginesCollection, List<Tire[]> tiresCollection)
        {
            string[] cmdArgs = input.Split();

            string make = cmdArgs[0];
            string model = cmdArgs[1];
            int year = int.Parse(cmdArgs[2]);
            double fuelQuantity = double.Parse(cmdArgs[3]);
            double fuelConsumtion = double.Parse(cmdArgs[4]);
            int engineIndex = int.Parse(cmdArgs[5]);
            int tiresArrIndex = int.Parse(cmdArgs[6]);

            Car car = new Car(make, model, year, fuelQuantity, fuelConsumtion,
                enginesCollection[engineIndex], tiresCollection[tiresArrIndex]);

            cars.Add(car);
        }

        private static bool IsSpecialCar(Car car)
        {
            if (car.Year >= 2017 && car.Engine.HorsePower > 330)
            {
                double tirePressureSum = 0;
                foreach (Tire tire in car.Tires)
                {
                    tirePressureSum += tire.Pressure;
                }
                if (tirePressureSum >= 9 && tirePressureSum <= 10)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
