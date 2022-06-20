using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numOfInput = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numOfInput; i++)
            {
                string[] input = Console.ReadLine().Split();
                cars.Add(CreateNewCar(input));
            }

            string command = Console.ReadLine();
            if (command == "fragile")
            {
                FragilePrint(cars);
            }
            else
            {
                FlammeblePrint(cars);
            }
        }

        private static Car CreateNewCar(string[] input)
        {
            string model = input[0];

            int engineSpeed = int.Parse(input[1]);
            int enginePower = int.Parse(input[2]);
            Engine engine = new Engine(engineSpeed, enginePower);

            int cargoWeight = int.Parse(input[3]);
            string cargoType = input[4];
            Cargo cargo = new Cargo(cargoType, cargoWeight);

            List<Tire> tires = new List<Tire>();
            for (int i = 0; i < 4; i++)
            {
                int tireCounter = 0;
                double tirePressure = double.Parse(input[5 + tireCounter]);
                int tireAge = int.Parse(input[6 + tireCounter]);

                Tire tire = new Tire(tireAge, tirePressure);
                tires.Add(tire);
                tireCounter += 2;
            }

            Car car = new Car(model, engine, cargo, tires);
            return car;
        }

        private static void FragilePrint(List<Car> cars)
        {
            foreach (Car car in cars)
            {
                bool isPrinted = false;
                if (car.Cargo.Type == "fragile")
                {
                    foreach (Tire tire in car.Tires)
                    {
                        if (tire.Pressure < 1)
                        {
                            Console.WriteLine(car.Model);
                            isPrinted = true;
                            break;
                        }
                    }
                    if (isPrinted)
                    {
                        continue;
                    }
                }
            }
        }

        private static void FlammeblePrint(List<Car> cars)
        {
            foreach (Car car in cars)
            {
                if (car.Cargo.Type == "flammable")
                {
                    if (car.Engine.Power > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
    }
}
