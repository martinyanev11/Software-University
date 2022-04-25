using System;

namespace _08._Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            double grade = double.Parse(Console.ReadLine());

            int gradeCount = 1;
            int exclutionCounter = 0;
            double averageGrade = 0;
            double gradeSum = grade;

            if (grade < 4.00)
            {
                exclutionCounter++;
            }

            while (exclutionCounter != 2)
            {

                grade = double.Parse(Console.ReadLine());

                if (grade < 4.00)
                {
                    exclutionCounter++;
                    if (exclutionCounter == 2)
                    {
                        Console.WriteLine($"{studentName} has been excluded at {gradeCount} grade");
                        break;
                    }
                }
                gradeSum += grade;
                gradeCount++;
                if (gradeCount == 12)
                {
                    averageGrade = gradeSum / gradeCount;
                    Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:f2}");
                    break;
                }
            }


        }
    }
}
