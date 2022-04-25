using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int toleranceForBadGrades = int.Parse(Console.ReadLine());
            int badGradesCounter = 0;
            bool reachedTheTolerance = false;

            int sumOfGrades = 0;
            int numberOfGrades = 0;

            string problemName = string.Empty;
            string input;
            while ((input = Console.ReadLine()) != "Enough")
            {
                problemName = input;
                int problemGrade = int.Parse(Console.ReadLine());
                sumOfGrades += problemGrade;
                numberOfGrades++;

                if (problemGrade <= 4)
                {
                    badGradesCounter++;
                }
                if (badGradesCounter == toleranceForBadGrades)
                {
                    reachedTheTolerance = true;
                    break;
                }
            }

            if (reachedTheTolerance)
            {
                Console.WriteLine($"You need a break, {badGradesCounter} poor grades.");
            }
            else
            {
                double averageGrade = (double)sumOfGrades / (double)numberOfGrades;
                Console.WriteLine($"Average score: {averageGrade:f2}");
                Console.WriteLine($"Number of problems: {numberOfGrades}");
                Console.WriteLine($"Last problem: {problemName}");
            }
        }
    }
}
