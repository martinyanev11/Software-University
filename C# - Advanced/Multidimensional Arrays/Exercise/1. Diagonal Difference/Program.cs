using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareMatrixSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[squareMatrixSize, squareMatrixSize];

            for (int row = 0; row < squareMatrixSize; row++)
            {
                int[] rowInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < rowInput.Length; col++)
                {
                    matrix[row, col] = rowInput[col];
                }
            }

            // Summing the elements in primary diagonal
            int primaryDiagonalSum = 0;
            
            for (int i = 0; i < squareMatrixSize; i++)
            {
                primaryDiagonalSum += matrix[i, i];
            }

            // Summing the elements in the secondary diagonal
            int secondaryDiagonalSum = 0;
            int currRow = 0;

            for (int col = squareMatrixSize - 1; col >= 0; col--)
            {
                secondaryDiagonalSum += matrix[currRow, col];
                currRow++;
            }

            int absoluteDifference = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
            Console.WriteLine(absoluteDifference);
        }
    }
}
