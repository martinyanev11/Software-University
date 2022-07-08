using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private const int baseModifier = 2;
        private const int weightMinValue = 1;
        private const int weightMaxValue = 50;

        private string type;
        private double weight;
        private double caloriesPerGram;

        private readonly Dictionary<string, double> modifiers = new Dictionary<string, double>()
        {
            { "Meat", 1.2  },
            { "Veggies", 0.8  },
            { "Cheese", 1.1  },
            { "Sauce", 0.9  },
        };

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
            this.CaloriesPerGram = this.CalculateCalories();
        }

        public string Type
        {
            get
            {
                return type;
            }
            private set
            {
                if (!modifiers.ContainsKey(value))
                {
                    throw new Exception($"Cannot place {value} on top of your pizza.");
                }
                type = value;
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }
            private set
            {
                if (value < weightMinValue || value > weightMaxValue)
                {
                    throw new Exception($"{this.Type} weight should be in the range [{weightMinValue}..{weightMaxValue}].");
                }
                weight = value;
            }
        }

        public double CaloriesPerGram
        {
            get { return caloriesPerGram; }
            private set { caloriesPerGram = value; }
        }

        private double CalculateCalories()
        {
            double toppingTypeModfier = this.modifiers[this.Type];

            double calories = (baseModifier * this.Weight) * toppingTypeModfier;
            return calories;
        }
    }
}
