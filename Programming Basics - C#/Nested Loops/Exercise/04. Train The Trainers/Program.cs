using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfJuryMembers = int.Parse(Console.ReadLine());    
            int presentationCounter = 0;
            double totalAverageGrade = 0;

            string presentationName;
            while ((presentationName = Console.ReadLine()) != "Finish")
            {
                double averageGradeForPresentation = 0;
                for (int i = 0; i < numberOfJuryMembers; i++)
                {
                    double grade = double.Parse(Console.ReadLine());

                    averageGradeForPresentation += grade;
                }
                presentationCounter++;
                averageGradeForPresentation /= numberOfJuryMembers;

                totalAverageGrade += averageGradeForPresentation;

                Console.WriteLine($"{presentationName} - {averageGradeForPresentation:f2}.");
            }

            totalAverageGrade /= presentationCounter;

            Console.WriteLine($"Student's final assessment is {totalAverageGrade:f2}.");
        }
    }
}
