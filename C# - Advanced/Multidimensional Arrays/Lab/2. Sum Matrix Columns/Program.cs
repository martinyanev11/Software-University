using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reading the matrix dimensions
            int[] matrixDimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = matrixDimensions[0];
            int columns = matrixDimensions[1];

            // Creating matrix with set dimensions and adding elements
            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                int[] rowInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = rowInput[j];
                }
            }

            // Printing the sum of each column in the matrix on a new line
            int columnSum = 0;

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    columnSum += matrix[j, i];
                }
                Console.WriteLine(columnSum);
                columnSum = 0;
            }
        }
    }
}
