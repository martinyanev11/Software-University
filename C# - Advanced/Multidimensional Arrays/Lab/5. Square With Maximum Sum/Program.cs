using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize matrix with dimensions given
            int[] dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int columns = dimensions[1];

            int[,] matrix = new int[rows, columns];

            // Fill the matrix
            for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) - the number of rows
            {
                int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(1) - the number of columns
                {
                    matrix[i, j] = input[j];
                }
            }

            // Find the 2x2 subMatrix with biggest sum
            int biggestSum = int.MinValue;
            int currSum = 0;
            int bestRowIndex = 0;
            int bestColIndex = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    currSum = matrix[row, col] + matrix[row, col + 1] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (biggestSum < currSum)
                    {
                        biggestSum = currSum;
                        bestRowIndex = row;
                        bestColIndex = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[bestRowIndex, bestColIndex]} {matrix[bestRowIndex, bestColIndex + 1]}");
            Console.WriteLine($"{matrix[bestRowIndex + 1, bestColIndex]} {matrix[bestRowIndex + 1, bestColIndex + 1]}");
            Console.WriteLine(biggestSum);

        }
    }
}
