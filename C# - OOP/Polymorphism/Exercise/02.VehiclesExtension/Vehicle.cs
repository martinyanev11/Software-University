using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        private double tankCapacity;

        public Vehicle(double fuelQuantity, double litersPerKm, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = litersPerKm;
            this.TankCapacity = tankCapacity;
        }

        public double FuelQuantity { get; protected set; }

        public double FuelConsumption { get; protected set; }

        public double AirConditionerConsumptionIndex { get; protected set; }

        public double TankCapacity
        {
            get
            {
                return this.tankCapacity;
            }
            private set
            {
                if (value > tankCapacity)
                {
                    Console.WriteLine($"Cannot fit {value} fuel in the tank");
                    this.tankCapacity = 0;
                }
                else
                {
                    this.tankCapacity = value;
                }
            }
        }

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
