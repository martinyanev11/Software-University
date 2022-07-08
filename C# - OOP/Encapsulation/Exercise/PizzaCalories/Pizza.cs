using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private readonly List<Topping> toppings;
        private double totalCalories;

        private Pizza()
        {
            this.toppings = new List<Topping>();
        }

        public Pizza(string name)
            : this()
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 15)
                {
                    throw new Exception("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }

        public Dough Dough { get; set; }

        public IReadOnlyCollection<Topping> Toppings
        {
            get
            {
                return this.toppings;
            }
        }

        public double TotalCalories
        {
            get
            {
                return totalCalories;
            }
            private set
            {
                totalCalories = value;
            }
        }

        internal void AddTopping(Topping topping)
        {
            if (toppings.Count <= 10)
            {
                toppings.Add(topping);
                TotalCalories = CalculateTotalCalories();
            }
            else
            {
                throw new Exception("Number of toppings should be in range [0..10].");
            }
        }

        private double CalculateTotalCalories()
        {
            double toppingsCaloriesSum = 0;
            foreach (var topping in toppings)
            {
                toppingsCaloriesSum += topping.CaloriesPerGram;
            }
            double result = this.Dough.CaloriesPerGram + toppingsCaloriesSum;
            return result;
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.TotalCalories:f2} Calories.";
        }
    }
}
