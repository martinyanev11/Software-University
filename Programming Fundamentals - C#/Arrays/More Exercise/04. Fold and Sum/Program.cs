using System;
using System.Linq;

namespace _04._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] initialArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rowLength = initialArr.Length / 2;

            int[] firstRowLeftSide = new int[rowLength / 2];
            int[] firstRowRightSide = new int[rowLength / 2];
            int[] secondRow = new int[rowLength];

            // Add elements to second row
            int counter = 0;
            for (int i = rowLength / 2; i < rowLength + (rowLength / 2); i++)
            {
                secondRow[counter] = initialArr[i];
                counter++;
            }

            // Add elements to first row - left side
            counter = 0;
            for (int i = 0; i < rowLength / 2; i++)
            {
                firstRowLeftSide[counter] = initialArr[i];
                counter++;
            }
            Array.Reverse(firstRowLeftSide);

            // Add elements to first row - right side
            counter = 0;
            for (int i = rowLength + (rowLength / 2); i < initialArr.Length; i++)
            {
                firstRowRightSide[counter] = initialArr[i];
                counter++;
            }
            Array.Reverse(firstRowRightSide);


            // Mergin the first row
            int[] mergedFirstRow = new int[rowLength];

            counter = 0;
            for (int i = 0; i < firstRowLeftSide.Length; i++)
            {
                mergedFirstRow[counter] = firstRowLeftSide[i];
                counter++;
            }
            for (int i = 0; i < firstRowRightSide.Length; i++)
            {
                mergedFirstRow[counter] = firstRowRightSide[i];
                counter++;
            }


            // Calculation array
            int[] summed = new int[rowLength];

            for (int i = 0; i < mergedFirstRow.Length; i++)
            {
                summed[i] = mergedFirstRow[i] + secondRow[i];
            }

            Console.WriteLine(string.Join(" ", summed));

        }
    }
}
