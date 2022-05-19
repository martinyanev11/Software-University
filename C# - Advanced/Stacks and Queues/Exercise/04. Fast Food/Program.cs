using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalFoodQuantity = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(orders);

            int biggestOrder = queue.Max();
            Console.WriteLine(biggestOrder);

            bool foodIsEnough = true;

            while (queue.Count > 0)
            {
                totalFoodQuantity -= queue.Peek();
                if (totalFoodQuantity < 0)
                {
                    foodIsEnough = false;
                    break;
                }
                else
                {
                    queue.Dequeue();
                }
            }

            if (foodIsEnough == true)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
            }

        }
    }
}
