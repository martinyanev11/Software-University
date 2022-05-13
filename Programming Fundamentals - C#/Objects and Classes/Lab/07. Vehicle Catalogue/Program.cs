using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    class Truck
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public double Weight { get; set; }
    }

    class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }
    }

    class Catalogue
    {
        public Catalogue()
        {
            this.Trucks = new List<Truck>();
            this.Cars = new List<Car>();
        }
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input;
            // Create a catalogue object instances with truck list and car list

            Catalogue vehiclesList = new Catalogue();
            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputSplit = input.Split("/");

                string type = inputSplit[0];
                string brand = inputSplit[1];
                string model = inputSplit[2];
                if (type == "Car")
                {
                    int horsePower = int.Parse(inputSplit[3]);
                    // Make new car object and add the properties
                    Car newCar = new Car();

                    newCar.Brand = brand;
                    newCar.Model = model;
                    newCar.HorsePower = horsePower;

                    // Add the new car object into the calalogue instance in cars list
                    vehiclesList.Cars.Add(newCar);
                }
                else
                {
                    double weight = double.Parse(inputSplit[3]);
                    // Make new truck object and add the properties
                    Truck newTruck = new Truck();

                    newTruck.Brand = brand;
                    newTruck.Model = model;
                    newTruck.Weight = weight;

                    // Add the new car object into the calalogue instance in trucks list
                    vehiclesList.Trucks.Add(newTruck);
                }

            }

            List<Car> orderedCarsList = vehiclesList.Cars.OrderBy(x => x.Brand).ToList();
            List<Truck> orderedTrucksList = vehiclesList.Trucks.OrderBy(x => x.Brand).ToList();

            if (vehiclesList.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in orderedCarsList)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (vehiclesList.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in orderedTrucksList)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }

        }
    }
}
