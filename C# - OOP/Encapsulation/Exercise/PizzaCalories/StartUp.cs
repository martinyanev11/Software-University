using System;

namespace PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                // Create pizza
                string[] pizzaInput = Console.ReadLine().Split();
                Pizza pizza = CreatePizza(pizzaInput);

                // Create dough
                string[] doughInput = Console.ReadLine().Split();
                Dough dough = CreateDough(doughInput);
                pizza.Dough = dough;

                // Create toppings
                string command;
                while ((command = Console.ReadLine()) != "END")
                {
                    string[] toppingArgs = command.Split();
                    Topping topping = CreateTopping(toppingArgs);
                    pizza.AddTopping(topping);
                }

                Console.WriteLine(pizza);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        private static Pizza CreatePizza(string[] pizzaInput)
        {
            string pizzaName = pizzaInput[1];
            return new Pizza(pizzaName);
        }

        private static Dough CreateDough(string[] doughInput)
        {
            string flourType = doughInput[1];
            flourType = char.ToUpper(flourType[0]) + flourType.Substring(1).ToLower();

            string bakingTechnique = doughInput[2];
            bakingTechnique = char.ToUpper(bakingTechnique[0]) + bakingTechnique.Substring(1).ToLower();

            double weight = double.Parse(doughInput[3]);

            return new Dough(flourType, bakingTechnique, weight);
        }

        private static Topping CreateTopping(string[] toppingArgs)
        {
            string toppingType = toppingArgs[1];
            toppingType = char.ToUpper(toppingType[0]) + toppingType.Substring(1).ToLower();

            double toppingWeight = double.Parse(toppingArgs[2]);

            return new Topping(toppingType, toppingWeight);
        }
    }
}
