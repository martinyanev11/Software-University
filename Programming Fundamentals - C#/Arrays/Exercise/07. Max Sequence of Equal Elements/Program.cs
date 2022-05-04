using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sequanceCounter = 0;
            int sequanceMax = 0;
            int sequanceValue = int.MinValue;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    sequanceCounter++;
                    if (sequanceCounter > sequanceMax)
                    {
                        sequanceMax = sequanceCounter;
                        sequanceValue = array[i];
                    }
                }
                else
                {
                    sequanceCounter = 0;
                }
            }

            for (int i = 0; i <= sequanceMax; i++)
            {
                Console.Write($"{sequanceValue} ");
            }
            Console.WriteLine();
        }
    }
}
