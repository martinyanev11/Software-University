using System;

namespace _08._Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string seriesName = Console.ReadLine();
            double episodeLenght = double.Parse(Console.ReadLine());
            double breakLenght = double.Parse(Console.ReadLine());

            double lunchTime = breakLenght / 8;
            double restTime = breakLenght / 4;

            double timeLeft = breakLenght - (lunchTime + restTime);

            if (timeLeft >= episodeLenght)
            {
                Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(timeLeft - episodeLenght)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(episodeLenght - timeLeft)} more minutes.");
            }
        }
    }
}
