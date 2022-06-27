using System;
using System.Linq;
using System.Collections.Generic;

namespace _01_Meal_Plan
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mealsInput = Console.ReadLine().Split();
            int[] caloriesInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<string> meals = new Queue<string>(mealsInput);
            Stack<int> dailyCallories = new Stack<int>(caloriesInput);

            Dictionary<string, int> mealCallories = new Dictionary<string, int>
            {
                { "salad", 350 },
                { "soup", 490 },
                { "pasta", 680 },
                { "steak", 790 }
            };

            bool ateAllCallories = false;

            while (meals.Count > 0 && dailyCallories.Count > 0)
            {
                string currentMeal = meals.Peek();
                int currentDailyCalories = dailyCallories.Pop();

                int currentMealCallories = mealCallories[currentMeal];

                if (currentDailyCalories - currentMealCallories > 0)
                {
                    currentDailyCalories -= currentMealCallories;
                    
                    dailyCallories.Push(currentDailyCalories); // push back the left calories
                    meals.Dequeue(); // the meal is eaten, remove it from the queue
                }
                else if (currentDailyCalories - currentMealCallories == 0)
                {
                    meals.Dequeue(); // The currentDailyCalories has been "Poped", we just dequeue the meal
                }
                else if (currentDailyCalories - currentMealCallories < 0)
                {
                    int leftOverCalories = currentMealCallories - currentDailyCalories;
                    if (dailyCallories.Count > 0)
                    {
                        int nextDayDailyCalories = dailyCallories.Pop();

                        // I assume due to constains teling me I don't need recursion,
                        // the leftover is always less cal than the next day calories
                        nextDayDailyCalories -= leftOverCalories;

                        dailyCallories.Push(nextDayDailyCalories); // push back the nextdayCalories
                        meals.Dequeue(); // Remove the eaten meal
                    }
                    else
                    {
                        meals.Dequeue(); // Remove the meal even if not fully eaten according to the task

                        Console.WriteLine($"John ate enough, he had {mealsInput.Length - meals.Count} meals.");
                        Console.WriteLine($"Meals left: {string.Join (", ", meals)}.");
                        ateAllCallories = true;
                        break;
                    }
                }
            }

            if (!ateAllCallories)
            {
                Console.WriteLine($"John had {mealsInput.Length} meals.");
                Console.WriteLine($"For the next few days, he can eat {string.Join(", ", dailyCallories)} calories.");
            }
        }
    }
}
