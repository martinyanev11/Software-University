using System;

namespace _04._Cat_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int catsNumber = int.Parse(Console.ReadLine());

            int groupCounter1 = 0;
            int groupCounter2 = 0;
            int groupCounter3 = 0;

            double totalFood = 0;
            double pricePerKg = 12.45;
            double totalPrice = 0;

            for (int i = 0; i < catsNumber; i++)
            {
                int foodEat = int.Parse(Console.ReadLine());
                totalFood += foodEat;
                if (foodEat >= 100 && foodEat < 200)
                {
                    groupCounter1++;
                }
                else if (foodEat >= 200 && foodEat < 300)
                {
                    groupCounter2++;
                }
                else if (foodEat >= 300 && foodEat < 400)
                {
                    groupCounter3++;
                }
            }

            totalFood /= 1000;
            totalPrice = totalFood * pricePerKg;

            Console.WriteLine($"Group 1: {groupCounter1} cats.");
            Console.WriteLine($"Group 2: {groupCounter2} cats.");
            Console.WriteLine($"Group 3: {groupCounter3} cats.");
            Console.WriteLine($"Price for food per day: {totalPrice:f2} lv.");
            
        }
    }
}
