using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories
{
    public class Pizza // step 5 to be continued!
    {
        private string name;
        private readonly List<Topping> toppings;
        private double totalCalories;

        private Pizza(Topping[] toppings)
        {
            this.toppings = toppings.ToList();
            totalCalories = CalculateTotalCalories();
        }

        public Pizza(string name, Dough dough, params Topping[] toppings)
            : this(toppings)
        {
            this.Name = name;
            this.Dough = dough;
        }

        public string Name
        {
            get 
            {
                return name;
            }
            private set
            {
                name = value;
            }
        }

        public Dough Dough { get; private set; }

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
    }
}
