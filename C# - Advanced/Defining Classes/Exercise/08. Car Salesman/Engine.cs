using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Engine
    {
        public Engine(string model, int power, string displacement, string efficiency)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }

        public string Model { get; set; }

        public int Power { get; set; }

        public string Displacement { get; set; }

        public string Efficiency { get; set; }
    }
}
