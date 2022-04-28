using System;

namespace _04._Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            int sum = 0;

            while (endNumber >= startNumber)
            {
                Console.Write($"{startNumber} ");
                sum += startNumber;
                startNumber++;
            }
            Console.WriteLine("");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
