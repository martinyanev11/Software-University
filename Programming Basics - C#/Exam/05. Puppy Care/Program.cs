using System;

namespace _05._Puppy_Care
{
    class Program
    {
        static void Main(string[] args)
        {
            int kgFoodBought = int.Parse(Console.ReadLine());
            kgFoodBought *= 1000; //convert to grams

            string nextDay = Console.ReadLine();
            int totalFood = 0;

            while (nextDay != "Adopted")
            {
                int foodForToday = int.Parse(nextDay);
                totalFood += foodForToday;
                nextDay = Console.ReadLine();
            }

            int foodLeft = Math.Abs(kgFoodBought - totalFood);

            if (kgFoodBought >= totalFood)
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodLeft} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {foodLeft} grams more.");
            }
        }
    }
}
