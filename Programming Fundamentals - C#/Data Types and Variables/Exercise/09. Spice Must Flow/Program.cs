using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int totalExtractedSpices = 0;
            int days = 0;

            while (startingYield >= 100)
            {
                totalExtractedSpices += startingYield;
                totalExtractedSpices -= 26;
                startingYield -= 10;
                days++;
            }

            if (totalExtractedSpices > 0)
            {
                totalExtractedSpices -= 26;
            }

            Console.WriteLine(days);
            Console.WriteLine(totalExtractedSpices);
        }
    }
}
