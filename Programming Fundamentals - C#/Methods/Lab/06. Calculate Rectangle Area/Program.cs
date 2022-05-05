using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            double area = RectangleArea(height, width);
            Console.WriteLine(area);
        }

        static double RectangleArea(int height, int width)
        {
            return height * width;
        }
    }
}
