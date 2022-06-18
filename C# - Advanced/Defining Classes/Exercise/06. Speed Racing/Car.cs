using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
        {
            Model = model;
            Fuel = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKm;
            TravelledDistance = 0;
        }

        public string Model { get; set; }

        public double Fuel { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TravelledDistance { get; set; }

        public void Drive(Car car, double amountOfKm)
        {
            double litersFuelNeeded = amountOfKm * car.FuelConsumptionPerKilometer;
            if (car.Fuel >= litersFuelNeeded)
            {
                car.Fuel -= litersFuelNeeded;
                car.TravelledDistance += amountOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
