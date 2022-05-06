using System;
using System.Linq;

namespace _05._Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int longestSubseqLength = 0;
            int currentNum = int.MinValue;
            bool foundBiggerNum = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (currentNum < array[i])
                {
                    currentNum = array[i];
                }
            }
        }
    }
}
