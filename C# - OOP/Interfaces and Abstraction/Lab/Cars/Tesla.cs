using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        private int battery;
        private string model;
        private string color;

        public Tesla(string model, string color, int battery)
        {
            this.Model = model;
            this.Color = color;
            this.Battery = battery;
        }

        public int Battery 
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }
        public string Model 
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }
        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Color} Tesla {this.Model} with {this.Battery} Batteries");
            sb.AppendLine(Start());
            sb.Append(Stop());
            return sb.ToString();
        }
    }
}
