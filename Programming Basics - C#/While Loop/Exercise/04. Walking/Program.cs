using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int stepsTarget = 10000;
            int totalStepsCount = 0;
            int steps = 0;

            while (totalStepsCount < stepsTarget)
            {
                string input = Console.ReadLine();
                if (input == "Going home")
                {
                    steps = int.Parse(Console.ReadLine());
                    totalStepsCount += steps;
                    break;
                }
                else
                {
                    steps = int.Parse(input);
                    totalStepsCount += steps;
                }
            }

            int difference = Math.Abs(stepsTarget - totalStepsCount);

            if (totalStepsCount >= stepsTarget)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{difference} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{difference} more steps to reach goal.");
            }

        }
    }
}
