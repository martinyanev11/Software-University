using System;
using System.Linq;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            VowCounter(input);
        }

        // Old Solution - 05-03-2022
        //static void VowCounter(string input)
        //{
        //    int vowCounter = 0;
        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u' || input[i] == 'y')
        //        {
        //            vowCounter++;
        //        }
        //    }
        //    Console.WriteLine(vowCounter);
        //}


        // New Solution - 06-05-2022
        static void VowCounter(string input)
        {
            int vowCounter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if ("aeiouy".Contains(input[i].ToString()))
                {
                    vowCounter++;
                }
            }
            Console.WriteLine(vowCounter);
        }
    }
}
