using System;

namespace _07._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            // Size of the apartment
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int totalCubicMetersSpace = width * length * height;

            string input;
            while ((input = Console.ReadLine()) != "Done")
            {
                int boxesMoved = int.Parse(input);
                totalCubicMetersSpace -= boxesMoved;
                if (totalCubicMetersSpace < 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(totalCubicMetersSpace)} Cubic meters more.");
                    break;
                }
            }

            if (totalCubicMetersSpace >= 0)
            {
                Console.WriteLine($"{totalCubicMetersSpace} Cubic meters left.");
            }
        }
    }
}
