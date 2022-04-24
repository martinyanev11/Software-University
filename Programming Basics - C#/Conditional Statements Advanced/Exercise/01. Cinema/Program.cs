using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            // USER INPUT
            string projection = Console.ReadLine();
            double rows = double.Parse(Console.ReadLine());
            double colums = double.Parse(Console.ReadLine());

            // CALCULATION OF RECTANGLE
            double area = rows * colums;

            switch (projection)
            {
                case "Premiere":
                    Console.WriteLine($"{(area * 12):f2} leva");
                    break;
                case "Normal":
                    Console.WriteLine($"{(area * 7.5):f2} leva");
                    break;
                case "Discount":
                    Console.WriteLine($"{(area * 5):f2} leva");
                    break;
            }
        }
    }
}
