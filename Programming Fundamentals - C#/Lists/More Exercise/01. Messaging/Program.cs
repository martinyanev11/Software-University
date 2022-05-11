using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = Console.ReadLine().Split().Select(int.Parse).ToList();

            string sentence = Console.ReadLine();

            List<int> summedNumbers = new List<int>();
            foreach (int number in numberList)
            {
                int tempSum = 0;
                int lastDigit = 0;
                int currentNumber = number;

                while (currentNumber > 0)
                {
                    lastDigit = currentNumber % 10;
                    tempSum += lastDigit;
                    currentNumber /= 10;
                }

                summedNumbers.Add(tempSum);
            }

            string outputMessage = string.Empty;
            
            foreach (int summedNumber in summedNumbers)
            {
                int currSumNum = summedNumber;
                while (currSumNum > sentence.Length - 1)
                {
                    currSumNum -= sentence.Length;
                }

                char tempChar = sentence[currSumNum];
                outputMessage += tempChar;
                sentence = sentence.Remove(currSumNum, 1);    
            }

            Console.WriteLine(outputMessage);
        }
    }
}
