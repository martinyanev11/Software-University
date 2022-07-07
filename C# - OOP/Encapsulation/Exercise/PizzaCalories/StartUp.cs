using System;

namespace PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string command;
                while ((command = Console.ReadLine()) != "END")
                {
                    string[] cmdArgs = command.Split();

                    string inputType = cmdArgs[0];
                    if (inputType == "Dough")
                    {
                        string flourType = cmdArgs[1];
                        flourType = char.ToUpper(flourType[0]) + flourType.Substring(1);

                        string bakingTechnique = cmdArgs[2];
                        bakingTechnique = char.ToUpper(bakingTechnique[0]) + bakingTechnique.Substring(1);

                        double weight = double.Parse(cmdArgs[3]);

                        Dough dough = new Dough(flourType, bakingTechnique, weight);
                        Console.WriteLine($"{dough.CaloriesPerGram:f2}");
                    }
                    else if (inputType == "Topping")
                    {
                        string toppingType = cmdArgs[1];
                        toppingType = char.ToUpper(toppingType[0]) + toppingType.Substring(1);

                        double weight = double.Parse(cmdArgs[2]);

                        Topping topping = new Topping(toppingType, weight);
                        Console.WriteLine($"{topping.CaloriesPerGram:f2}");
                    }
                    
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            
            


        }
    }
}
