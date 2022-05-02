using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballsCount = int.Parse(Console.ReadLine());

            BigInteger highestValue = 0;
            int highestValueSnowballSnow = 0;
            int highestValueSnowballTime = 0;
            int highestValueSnowballQuality = 0;

            for (int i = 0; i < snowballsCount; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                if (highestValue < snowballValue)
                {
                    highestValue = snowballValue;
                    highestValueSnowballSnow = snowballSnow;
                    highestValueSnowballTime = snowballTime;
                    highestValueSnowballQuality = snowballQuality;
                }
            }

            Console.WriteLine($"{highestValueSnowballSnow} : {highestValueSnowballTime} = {highestValue} ({highestValueSnowballQuality})");
        }
    }
}
