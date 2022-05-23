using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create matrix with given dimensions from the console
            int[] matrixDimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = matrixDimensions[0];
            int columns = matrixDimensions[1];

            string[,] matrix = new string[rows, columns];

            // Fill the matrix with info from the console
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] currRowInfo = Console.ReadLine().Split();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currRowInfo[col];
                }
            }

            // Find 2x2 matrix with same chars
            int sameCharMatrixes2x2Found = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] && matrix[row, col] ==
                        matrix[row + 1, col] && matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        sameCharMatrixes2x2Found++;
                    } 

                }
            }

            Console.WriteLine(sameCharMatrixes2x2Found);

        }
    }
}
