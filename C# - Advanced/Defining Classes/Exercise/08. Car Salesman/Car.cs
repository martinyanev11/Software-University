using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        public Car(string model, Engine engine, string weight, string color)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public string Weight { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            return $"{Model}:\n" +
                $"  {Engine.Model}:\n" +
                $"    Power: {Engine.Power}\n" +
                $"    Displacement: {Engine.Displacement}\n" +
                $"    Efficiency: {Engine.Efficiency}\n" +
                $"  Weight: {Weight}\n" +
                $"  Color: {Color}";
        }
    }
}
