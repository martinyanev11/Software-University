using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize a square matrix
            int squareMatrixDimensions = int.Parse(Console.ReadLine());
            int[,] matrix = new int[squareMatrixDimensions, squareMatrixDimensions];

            // Fill the matrix with elements
            for (int rows = 0; rows < squareMatrixDimensions; rows++)
            {
                int[] rowInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int column = 0; column < squareMatrixDimensions; column++)
                {
                    matrix[rows, column] = rowInput[column];
                }
            }

            // Calculate the matrix's primary diagonal sum
            int diagonalSum = 0;

            for (int i = 0; i < squareMatrixDimensions; i++)
            {
                diagonalSum += matrix[i, i];
            }

            Console.WriteLine(diagonalSum);
        }
    }
}
