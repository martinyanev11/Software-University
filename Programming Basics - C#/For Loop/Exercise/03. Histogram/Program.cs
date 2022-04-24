using System;

namespace _03._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double p1 = 0; // <= 200
            double p2 = 0; // 200 - 399
            double p3 = 0; // 400 - 599
            double p4 = 0; // 600 - 799
            double p5 = 0; // >= 800 

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    p1 += 1;
                }
                else if (number >= 200 && number <= 399)
                {
                    p2 += 1;
                }
                else if (number >= 400 && number <= 599)
                {
                    p3 += 1;
                }
                else if (number >= 600 && number <= 799)
                {
                    p4 += 1;
                }
                else if (number >= 800)
                {
                    p5 += 1;
                }
            }

            Console.WriteLine($"{(p1 / n * 100):f2}%");
            Console.WriteLine($"{(p2 / n * 100):f2}%");
            Console.WriteLine($"{(p3 / n * 100):f2}%");
            Console.WriteLine($"{(p4 / n * 100):f2}%");
            Console.WriteLine($"{(p5 / n * 100):f2}%");
        }
    }
}
