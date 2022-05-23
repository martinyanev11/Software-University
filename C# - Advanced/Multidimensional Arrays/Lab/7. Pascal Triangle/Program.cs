using System;

namespace _7._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());

            long[][] jaggedMatrix = new long[rowsCount][];

            for (int row = 0; row < jaggedMatrix.Length; row++)
            {
                jaggedMatrix[row] = new long[row + 1];
                jaggedMatrix[row][0] = 1; // first element is always 1 on each row
                jaggedMatrix[row][jaggedMatrix[row].Length - 1] = 1; // last element is always 1 as well

                for (int col = 1; col < jaggedMatrix[row].Length - 1; col++)
                {
                    jaggedMatrix[row][col] = jaggedMatrix[row - 1][col - 1] + jaggedMatrix[row - 1][col];
                }
            }

            // Printing the matrix on the console
            foreach (long[] row in jaggedMatrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
