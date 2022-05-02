﻿using System;

namespace _10._Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int pokeCount = 0;
            int initialpokePower = pokePower;
            bool isDivisibleByHalf = (pokePower - pokePower / 2) / exhaustionFactor != 0;

            while (pokePower >= distance)
            {
                pokePower -= distance;
                pokeCount++;

                if (isDivisibleByHalf && pokePower == initialpokePower / 2)
                {
                    pokePower /= exhaustionFactor;
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(pokeCount);
        }
    }
}
