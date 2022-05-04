using System;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            // INPUT
            int sequncesLenght = int.Parse(Console.ReadLine()); // THE LENGTH OF THE ARRAYS
            string[] stringArray = new string[sequncesLenght]; // MAKE A STRING ARRAY

            // BEST DNA ARRAY DECLARATIONS
            int[] bestDNASequnce = new int[sequncesLenght]; // ARRAY FOR BEST DNA
            int bestDNAOneSubsequncesCount = int.MinValue; // SUBSEQUNCES OF "1" COUNTER
            int bestDNALeftmostIndex = int.MinValue; // THE FIRST INDEX WITH "1" OF THE BEST DNA ARRAY
            int bestDNASequnceSum = 0; // THE BEST DNA SUM OF NUMBERS

            int bestDNAIndex = 0;
            int currentDNAIndex = 0;

            bool orderIsGiven = false; // MAKE A TRIGGER FOR PROGRAM END
            while (orderIsGiven == false)
            {
                string sequnceInput = Console.ReadLine(); // INPUT FROM USER AS STRING
                if (sequnceInput == "Clone them!") // CHECK IF THEY WANT TO END PROGRAM
                {
                    orderIsGiven = true;
                }
                else
                {
                    stringArray = sequnceInput.Split("!"); // CONVERT STRING INPUT FROM USER TO STRING ARRAY
                    currentDNAIndex++;
                    int[] currentArray = new int[sequncesLenght];
                    int currentSequnceSum = 0; // CURRENT ARRAY SUM
                    int currentLeftmostIndex = int.MinValue;
                    for (int i = 0; i < sequncesLenght; i++) // CONVERT STRING ARRAY TO CURRENT INT ARRAY AND SUM IT
                    {
                        currentArray[i] = int.Parse(stringArray[i]);
                        currentSequnceSum += currentArray[i];
                    }

                    int currentOneSubsequncesCount = 0;
                    bool isFirstIndex = true; // TRIGGER TO CHECK FIRST INDEX WITH "1"

                    for (int i = 0; i < currentArray.Length - 1; i++) // START COUNTING SUBSEQUNCES OF ONE
                    {
                        if (currentArray[i] == 1 && currentArray[i] == currentArray[i + 1])
                        {
                            currentOneSubsequncesCount++;
                            if (isFirstIndex == true) // SAVE THE FIRST "1" INDEX OF THE ARRAY
                            {
                                currentLeftmostIndex = i;
                                isFirstIndex = false;
                            }
                        }
                    }

                    // LOGIC CHECKS FOR BEST DNA
                    if (currentOneSubsequncesCount > bestDNAOneSubsequncesCount) // CHECK WHICH DNA HAS MORE "1" SEQUNCES
                    {
                        bestDNASequnce = currentArray;
                        bestDNAIndex = currentDNAIndex;
                        bestDNAOneSubsequncesCount = currentOneSubsequncesCount;
                        bestDNASequnceSum = currentSequnceSum;
                        bestDNALeftmostIndex = currentLeftmostIndex;
                    }
                    if (currentOneSubsequncesCount == 0 && bestDNAOneSubsequncesCount == 0) // IF NO SUBSEQUNCES OF "1"
                    {
                        for (int i = 0; i < currentArray.Length - 1; i++)
                        {
                            if (i == 1)
                            {
                                if (isFirstIndex == true) // SAVE THE FIRST "1" INDEX OF THE ARRAY
                                {
                                    currentLeftmostIndex = i;
                                    isFirstIndex = false;
                                }
                            }
                        }
                    }
                    else if (currentOneSubsequncesCount == bestDNAOneSubsequncesCount) // IF THEY HAVE SAME "1" SEQ.
                    {
                        if (currentLeftmostIndex < bestDNALeftmostIndex) // CHECK WHICH HAS EARLIER STARTING INDEX "1"
                        {
                            bestDNASequnce = currentArray;
                            bestDNAIndex = currentDNAIndex;
                            bestDNALeftmostIndex = currentLeftmostIndex;
                            bestDNASequnceSum = currentSequnceSum;
                            bestDNAOneSubsequncesCount = currentOneSubsequncesCount;
                        }
                        else if (currentLeftmostIndex == bestDNALeftmostIndex) // IF INDEXES ARE SAME CHECK WHICH SUM IS MORE
                        {
                            if (currentSequnceSum > bestDNASequnceSum)
                            {
                                bestDNASequnce = currentArray;
                                bestDNAIndex = currentDNAIndex;
                                bestDNALeftmostIndex = currentLeftmostIndex;
                                bestDNASequnceSum = currentSequnceSum;
                                bestDNAOneSubsequncesCount = currentOneSubsequncesCount;
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"Best DNA sample {bestDNAIndex} with sum: {bestDNASequnceSum}.");
            Console.WriteLine(string.Join(" ", bestDNASequnce));
        }
    }
}
