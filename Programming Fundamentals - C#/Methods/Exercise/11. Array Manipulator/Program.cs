using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] initialArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd == "end")
                {
                    Console.Write("[");
                    Console.Write(string.Join(", ", initialArray));
                    Console.WriteLine("]");
                    break;
                }

                string[] cmdArgs = cmd.Split();
                switch (cmdArgs[0])
                {
                    case "exchange":
                        int changeIndex = int.Parse(cmdArgs[1]);
                        if (changeIndex < 0 || changeIndex >= initialArray.Length)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            initialArray = Exchange(initialArray, changeIndex);
                        }
                        break;

                    case "max":
                        if (cmdArgs[1] == "even")
                        {
                            Console.WriteLine(MaxEvenIndex(initialArray));
                        }
                        else
                        {
                            Console.WriteLine(MaxOddIndex(initialArray));
                        }
                        break;

                    case "min":
                        if (cmdArgs[1] == "even")
                        {
                            Console.WriteLine(MinEvenIndex(initialArray));
                        }
                        else
                        {
                            Console.WriteLine(MinOddIndex(initialArray));
                        }
                        break;

                    case "first":
                        if (int.Parse(cmdArgs[1]) > initialArray.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            if (cmdArgs[2] == "even")
                            {
                                FirstNumberOfEven(initialArray, int.Parse(cmdArgs[1]));
                            }
                            else
                            {
                                FirstNumberOfOdd(initialArray, int.Parse(cmdArgs[1]));
                            }
                        }
                        break;

                    case "last":
                        if (int.Parse(cmdArgs[1]) > initialArray.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            if (cmdArgs[2] == "even")
                            {
                                LastNumberOfEven(initialArray, int.Parse(cmdArgs[1]));
                            }
                            else
                            {
                                LastNumberOfOdd(initialArray, int.Parse(cmdArgs[1]));
                            }
                        }
                        break;
                }
            }
        }

        static int[] Exchange(int[] arrayToExchange, int breakIndex)
        {
            int[] newArray = new int[arrayToExchange.Length];
            int newArrayIndexChanger = 0;
            for (int i = breakIndex + 1; i < arrayToExchange.Length; i++)
            {
                newArray[newArrayIndexChanger] = arrayToExchange[i];
                newArrayIndexChanger++;
            }
            int reversedNewArrayIndexChanger = arrayToExchange.Length - 1;
            for (int i = breakIndex; i >= 0; i--)
            {
                newArray[reversedNewArrayIndexChanger] = arrayToExchange[i];
                reversedNewArrayIndexChanger--;
            }

            return newArray;
        }

        static string MaxEvenIndex(int[] arrayToCheck)
        {
            int maxEvenValue = int.MinValue;
            int maxEvenIndex = 0;
            for (int i = 0; i < arrayToCheck.Length; i++)
            {
                if (arrayToCheck[i] % 2 == 0)
                {
                    if (maxEvenValue <= arrayToCheck[i])
                    {
                        maxEvenValue = arrayToCheck[i];
                        maxEvenIndex = i;
                    }
                }
            }
            if (maxEvenValue == int.MinValue)
            {
                return "No matches";
            }
            string convertedIndex = maxEvenIndex.ToString();
            return convertedIndex;
        }

        static string MaxOddIndex(int[] arrayToCheck)
        {
            int maxEvenValue = int.MinValue;
            int maxEvenIndex = 0;
            for (int i = 0; i < arrayToCheck.Length; i++)
            {
                if (arrayToCheck[i] % 2 != 0)
                {
                    if (maxEvenValue <= arrayToCheck[i])
                    {
                        maxEvenValue = arrayToCheck[i];
                        maxEvenIndex = i;
                    }
                }
            }
            if (maxEvenValue == int.MinValue)
            {
                return "No matches";
            }
            string convertedIndex = maxEvenIndex.ToString();
            return convertedIndex;
        }

        static string MinEvenIndex(int[] arrayToCheck)
        {
            int minEvenValue = int.MaxValue;
            int minEvenIndex = 0;
            for (int i = 0; i < arrayToCheck.Length; i++)
            {
                if (arrayToCheck[i] % 2 == 0)
                {
                    if (minEvenValue >= arrayToCheck[i])
                    {
                        minEvenValue = arrayToCheck[i];
                        minEvenIndex = i;
                    }
                }
            }
            if (minEvenValue == int.MaxValue)
            {
                return "No matches";
            }
            string convertedIndex = minEvenIndex.ToString();
            return convertedIndex;
        }

        static string MinOddIndex(int[] arrayToCheck)
        {
            int minEvenValue = int.MaxValue;
            int minEvenIndex = 0;
            for (int i = 0; i < arrayToCheck.Length; i++)
            {
                if (arrayToCheck[i] % 2 != 0)
                {
                    if (minEvenValue >= arrayToCheck[i])
                    {
                        minEvenValue = arrayToCheck[i];
                        minEvenIndex = i;
                    }
                }
            }
            if (minEvenValue == int.MaxValue)
            {
                return "No matches";
            }
            string convertedIndex = minEvenIndex.ToString();
            return convertedIndex;
        }

        static void FirstNumberOfEven(int[] ArrayToCheck, int numberOfElements)
        {
            int numberOfEvenFound = 0;
            int[] newArray = new int[numberOfElements];
            bool elementsAreFound = false;
            for (int i = 0; i < ArrayToCheck.Length; i++)
            {
                if (ArrayToCheck[i] % 2 == 0)
                {
                    newArray[numberOfEvenFound] = ArrayToCheck[i];
                    numberOfEvenFound++;
                }
                if (numberOfEvenFound == numberOfElements)
                {
                    Console.Write("[");
                    Console.Write(string.Join(", ", newArray));
                    Console.WriteLine("]");
                    elementsAreFound = true;
                    break;
                }
            }
            if (numberOfEvenFound == 0)
            {
                Console.WriteLine("[]");
            }
            else if (elementsAreFound == false)
            {
                Console.Write("[");
                Console.Write(string.Join(", ", newArray.Where(x => x != 0)));
                Console.WriteLine("]");
            }
        }

        static void FirstNumberOfOdd(int[] ArrayToCheck, int numberOfElements)
        {
            int numberOfOddFound = 0;
            int[] newArray = new int[numberOfElements];
            bool elementsAreFound = false;
            for (int i = 0; i < ArrayToCheck.Length; i++)
            {
                if (ArrayToCheck[i] % 2 != 0)
                {
                    newArray[numberOfOddFound] = ArrayToCheck[i];
                    numberOfOddFound++;
                }
                if (numberOfOddFound == numberOfElements)
                {
                    Console.Write("[");
                    Console.Write(string.Join(", ", newArray));
                    Console.WriteLine("]");
                    elementsAreFound = true;
                    break;
                }
            }
            if (numberOfOddFound == 0)
            {
                Console.WriteLine("[]");
            }
            else if (elementsAreFound == false)
            {
                Console.Write("[");
                Console.Write(string.Join(", ", newArray.Where(x => x != 0)));
                Console.WriteLine("]");
            }
        }

        static void LastNumberOfEven(int[] ArrayToCheck, int numberOfElements)
        {
            int numberOfEvenFound = 0;
            int newArrayIndexSorter = numberOfElements - 1;
            int[] newArray = new int[numberOfElements];
            bool elementsAreFound = false;
            for (int i = ArrayToCheck.Length - 1; i >= 0; i--)
            {
                if (ArrayToCheck[i] % 2 == 0)
                {
                    newArray[newArrayIndexSorter] = ArrayToCheck[i];
                    numberOfEvenFound++;
                    newArrayIndexSorter--;
                }
                if (numberOfEvenFound == numberOfElements)
                {
                    Console.Write("[");
                    Console.Write(string.Join(", ", newArray));
                    Console.WriteLine("]");
                    elementsAreFound = true;
                    break;
                }
            }
            if (numberOfEvenFound == 0)
            {
                Console.WriteLine("[]");
            }
            else if (elementsAreFound == false)
            {
                Console.Write("[");
                Console.Write(string.Join(", ", newArray.Where(x => x != 0)));
                Console.WriteLine("]");
            }
        }

        static void LastNumberOfOdd(int[] ArrayToCheck, int numberOfElements)
        {
            int numberOfEvenFound = 0;
            int newArrayIndexSorter = numberOfElements - 1;
            int[] newArray = new int[numberOfElements];
            bool elementsAreFound = false;
            for (int i = ArrayToCheck.Length - 1; i >= 0; i--)
            {
                if (ArrayToCheck[i] % 2 != 0)
                {
                    newArray[newArrayIndexSorter] = ArrayToCheck[i];
                    numberOfEvenFound++;
                    newArrayIndexSorter--;
                }
                if (numberOfEvenFound == numberOfElements)
                {
                    Console.Write("[");
                    Console.Write(string.Join(", ", newArray));
                    Console.WriteLine("]");
                    elementsAreFound = true;
                    break;
                }
            }
            if (numberOfEvenFound == 0)
            {
                Console.WriteLine("[]");
            }
            else if (elementsAreFound == false)
            {
                Console.Write("[");
                Console.Write(string.Join(", ", newArray.Where(x => x != 0)));
                Console.WriteLine("]");
            }
        }
    }
}
