using System;
using System.Linq;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>();

            int n = int.Parse(Console.ReadLine()); // num of engines
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                AddEngineToList(engines, input); 
            }

            List<Car> cars = new List<Car>();
            int m = int.Parse(Console.ReadLine()); // num of cars
            for (int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split();
                AddCarToList(engines, input, cars);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }

        private static void AddEngineToList(List<Engine> engines, string[] input)
        {
            string model = input[0];
            int power = int.Parse(input[1]);
            string displacement = "n/a";
            string efficiency = "n/a";

            if (input.Length > 2)
            {
                displacement = input[2];
                if (input.Length > 3)
                {
                    efficiency = input[3];
                }
            }

            Engine engine = new Engine(model, power, displacement, efficiency);
            engines.Add(engine);
        }

        private static void AddCarToList(List<Engine> engines, string[] input, List<Car> cars)
        {
            string model = input[0];
            Engine engine = (engines.First(x => x.Model == input[1]));
            string weight = "n/a";
            string color = "n/a";

            if (input.Length > 2)
            {
                weight = input[2];
                if (input.Length > 3)
                {
                    color = input[3];
                }
            }

            Car car = new Car(model, engine, weight, color);
            cars.Add(car);
        }
    }
}
