using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Getting the dimensions for the matrix
            int[] matrixDimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = matrixDimensions[0];
            int columns = matrixDimensions[1];

            // Creating the matrix
            int[,] matrix = new int[rows, columns];
            int matrixSum = 0;

            for (int i = 0; i < rows; i++)
            {
                int[] currentRowElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = currentRowElements[j];
                    matrixSum += matrix[i, j];
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(columns);
            Console.WriteLine(matrixSum);
        }
    }
}
