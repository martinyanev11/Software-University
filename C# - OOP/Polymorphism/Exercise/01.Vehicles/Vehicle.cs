using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        public Vehicle(double fuelQuantity, double litersPerKm)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = litersPerKm;
        }

        public double FuelQuantity { get; protected set; }

        public double FuelConsumption { get; protected set; }

        public double AirConditionerConsumptionIndex { get; protected set; }

        public abstract string Drive(double distance);
        

        public virtual void Refuel(double fuelToAdd)
        {
            this.FuelQuantity += fuelToAdd;
        }

        public override string ToString()
        {
            return $"{(this.GetType().Name)}: {this.FuelQuantity:f2}";
        }
    }
}
