using System;
using System.Linq;

namespace _8._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[,] matrix = new int[matrixSize, matrixSize];

            for (int row = 0; row < matrixSize; row++)
            {
                int[] rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrixSize; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            // Explosion phase
            string[] allBombs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < allBombs.Length; i++)
            {
                int[] currentBombCoordinates = allBombs[i].Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int row = currentBombCoordinates[0];
                int col = currentBombCoordinates[1];

                int bombDamage = matrix[row, col];

                // Deal damage to all the neighbouring cells
                if (bombDamage > 0)
                {
                    if (LegitCoordinates(matrix, row - 1, col - 1)) //#1
                    {
                        matrix[row - 1, col - 1] -= bombDamage;
                    }
                    if (LegitCoordinates(matrix, row - 1, col)) //#2
                    {
                        matrix[row - 1, col] -= bombDamage;
                    }
                    if (LegitCoordinates(matrix, row - 1, col + 1)) //#3
                    {
                        matrix[row - 1, col + 1] -= bombDamage;
                    }
                    if (LegitCoordinates(matrix, row, col - 1)) //#4
                    {
                        matrix[row, col - 1] -= bombDamage;
                    }
                    if (LegitCoordinates(matrix, row, col + 1)) //#5
                    {
                        matrix[row, col + 1] -= bombDamage;
                    }
                    if (LegitCoordinates(matrix, row + 1, col - 1)) //#6
                    {
                        matrix[row + 1, col - 1] -= bombDamage;
                    }
                    if (LegitCoordinates(matrix, row + 1, col)) //#7
                    {
                        matrix[row + 1, col] -= bombDamage;
                    }
                    if (LegitCoordinates(matrix, row + 1, col + 1)) //#8
                    {
                        matrix[row + 1, col + 1] -= bombDamage;
                    }

                    // turn the exploded cell to 0
                    matrix[row, col] = 0;
                }
            }

            int aliveCellsSum = 0;
            int aliveCellsCount = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        aliveCellsCount++;
                        aliveCellsSum += matrix[row, col];
                    }
                }
            }

            Console.WriteLine($"Alive cells: {aliveCellsCount}");
            Console.WriteLine($"Sum: {Math.Abs(aliveCellsSum)}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }

        private static bool LegitCoordinates(int[,] matrix, int row, int col)
        {
            //return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
            bool isInMatrixRange = false;
            bool cellIsNotDead = false;

            if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
            {
                isInMatrixRange = true;

                if (matrix[row, col] > 0)
                {
                    cellIsNotDead = true;
                }
            }

            if (isInMatrixRange == true && cellIsNotDead == true)
            {
                return true;
            }
            return false;
        }
    }
}
