using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle, IVehicle
    {
        public Car(double fuelQuantity, double litersPerKm, double tankCapacity) 
            : base(fuelQuantity, litersPerKm, tankCapacity)
        {
            this.AirConditionerConsumptionIndex = 0.9;
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
    }
}
