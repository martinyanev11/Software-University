using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int kegsNumber = int.Parse(Console.ReadLine());
            double biggestKeg = double.MinValue;
            string biggestKegName = string.Empty;

            for (int i = 0; i < kegsNumber; i++)
            {
                string kegModel = Console.ReadLine();
                double kegRadius = double.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());

                double calculation = Math.PI * Math.Pow(kegRadius, 2) * kegHeight;
                if (biggestKeg < calculation)
                {
                    biggestKeg = calculation;
                    biggestKegName = kegModel;
                }
            }
            Console.WriteLine(biggestKegName);
        }
    }
}
