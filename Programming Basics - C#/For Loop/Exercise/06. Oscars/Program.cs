using System;

namespace _06._Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double academyScore = double.Parse(Console.ReadLine());
            int numOfJudges = int.Parse(Console.ReadLine());

            double totalScore = academyScore;

            for (int i = 0; i < numOfJudges; i++)
            {
                string nameOfJudge = Console.ReadLine();
                double judgeScore = double.Parse(Console.ReadLine());

                judgeScore = nameOfJudge.Length * judgeScore / 2;
                totalScore += judgeScore;

                if (totalScore > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {totalScore:f1}!");
                    break;
                }
            }

            if (totalScore <= 1250.5)
            {
                Console.WriteLine($"Sorry, {actorName} you need {(1250.5 - totalScore):f1} more!");
            }
        }
    }
}
