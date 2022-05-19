using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());

            int currentFillOfRack = 0;
            int rackCounter = 1;
            int currentClothesValue = 0;

            Stack<int> stackedClothes = new Stack<int>(clothes);

            while (stackedClothes.Count > 0)
            {
                currentClothesValue = stackedClothes.Peek();
                if (currentClothesValue + currentFillOfRack <= rackCapacity)
                {
                    currentFillOfRack += currentClothesValue;
                    stackedClothes.Pop();
                }
                else
                {
                    currentFillOfRack = 0;
                    rackCounter++;
                }
            }

            Console.WriteLine(rackCounter);
        }
    }
}
