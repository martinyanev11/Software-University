using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private const int baseModifier = 2;
        private const string doughTypeExceptionMessage = "Invalid type of dough.";
        private const int doughWeightMinLimit = 1;
        private const int doughWeightMaxLimit = 200;

        private string flourType;
        private string bakingTechnique;
        private double weight;
        private double caloriesPerGram;

        private readonly Dictionary<string, double> modifiers = new Dictionary<string, double>()
        {
            { "White", 1.5  },
            { "Wholegrain", 1.0  },
            { "Crispy", 0.9  },
            { "Chewy", 1.1  },
            { "Homemade", 1.0  },
        };

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
            this.CaloriesPerGram = this.CalculateCalories();
        }

        public string FlourType
        {
            get
            {
                return flourType;
            }
            private set
            {
                if (!modifiers.ContainsKey(value))
                {
                    throw new Exception(doughTypeExceptionMessage);
                }
                flourType = value;
            }
        }

        public string BakingTechnique
        {
            get
            {
                return bakingTechnique;
            }
            private set
            {
                if (!modifiers.ContainsKey(value))
                {
                    throw new Exception(doughTypeExceptionMessage);
                }
                bakingTechnique = value;
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
                if (value < doughWeightMinLimit || value > doughWeightMaxLimit)
                {
                    throw new Exception($"Dough weight should be in the range [{doughWeightMinLimit}..{doughWeightMaxLimit}].");
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
            double flourTypeModifierValue = this.modifiers[this.FlourType];
            double bakingTechniqueValue = this.modifiers[this.BakingTechnique];

            double calories = (baseModifier * this.Weight) * flourTypeModifierValue * bakingTechniqueValue;
            return calories;
        }
    }
}
