using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] array = Console.ReadLine().Split().Select(float.Parse).ToArray();
            float roundedNum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                roundedNum = (float)Math.Round(array[i], MidpointRounding.AwayFromZero);
                if (roundedNum == -0)
                {
                    roundedNum = 0;
                }
                Console.WriteLine($"{array[i]} => {roundedNum}");
            }
        }
    }
}
