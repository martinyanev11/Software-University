using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Truck : Vehicle, IVehicle
    {
        public Truck(double fuelQuantity, double litersPerKm, double tankCapacity)
            : base(fuelQuantity, litersPerKm, tankCapacity)
        {
            this.AirConditionerConsumptionIndex = 1.6;
        }

        public override string Drive(double distance)
        {
            double totalConsumption = this.FuelConsumption + this.AirConditionerConsumptionIndex;
            double fuelNeeded = totalConsumption * distance;

            if (this.FuelQuantity >= fuelNeeded)
            {
                this.FuelQuantity -= fuelNeeded;
                return $"{this.GetType().Name} travelled {distance} km";
            }
            return $"{this.GetType().Name} needs refueling";
        }

        public override void Refuel(double fuelToAdd)
        {
            double fuelLeakResult = fuelToAdd * 0.95;
            this.FuelQuantity += fuelLeakResult;
        }
    }
}
