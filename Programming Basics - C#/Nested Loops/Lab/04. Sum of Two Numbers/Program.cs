using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowerLimit = int.Parse(Console.ReadLine());
            int upperLimit = int.Parse(Console.ReadLine());
            int magicalNum = int.Parse(Console.ReadLine());

            int combinationsCounter = 0;
            bool combinationIsFound = false;
            int firstNumber = 0;
            int secondNumber = 0;
            

            for (firstNumber = lowerLimit; firstNumber <= upperLimit; firstNumber++)
            {
                for (secondNumber = lowerLimit; secondNumber <= upperLimit; secondNumber++)
                {
                    combinationsCounter++;
                    if (firstNumber + secondNumber == magicalNum)
                    {
                        combinationIsFound = true;
                        break;
                    }
                }
                if (combinationIsFound == true)
                {
                    break;
                }
            }

            if (combinationIsFound == true)
            {
                Console.WriteLine($"Combination N:{combinationsCounter} ({firstNumber} + {secondNumber} = {magicalNum})");
            }
            else
            {
                Console.WriteLine($"{combinationsCounter} combinations - neither equals {magicalNum}");
            }
        }
    }
}
