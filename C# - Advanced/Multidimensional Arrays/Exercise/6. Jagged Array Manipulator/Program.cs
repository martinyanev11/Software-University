using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize and fill jagged matrix
            int rowsCount = int.Parse(Console.ReadLine());
            int[][] jagged = new int[rowsCount][];

            for (int row = 0; row < rowsCount; row++)
            {
                int[] rowInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jagged[row] = rowInput;
            }

            // Analyze row lengths
            for (int row = 0; row < rowsCount - 1; row++)
            {
                int topRowLenght = jagged[row].Length;
                int bottomRowLength = jagged[row + 1].Length;

                if (topRowLenght == bottomRowLength) // If length of top and bottom rows are equal multiply by 2
                {
                    for (int col = 0; col < topRowLenght; col++)
                    {
                        jagged[row][col] *= 2;
                        jagged[row + 1][col] *= 2;
                    }
                }
                else // else divide by 2
                {
                    for (int col = 0; col < topRowLenght; col++)
                    {
                        jagged[row][col] /= 2;
                    }
                    for (int col = 0; col < bottomRowLength; col++)
                    {
                        jagged[row + 1][col] /= 2;
                    }
                }
            }


            // Execute commands given from console
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = input.Split();
                string commandType = cmdArgs[0];
                int row = int.Parse(cmdArgs[1]);
                int col = int.Parse(cmdArgs[2]);
                int value = int.Parse(cmdArgs[3]);

                bool legitCoordinates = false;

                if (row >= 0 && row < jagged.Length)
                {
                    if (col >= 0 && col < jagged[row].Length)
                    {
                        legitCoordinates = true;
                    }
                }

                if (legitCoordinates)
                {
                    if (commandType == "Add")
                    {
                        jagged[row][col] += value;
                    }
                    else if (commandType == "Subtract")
                    {
                        jagged[row][col] -= value;
                    }
                }
            }

            // Print the final state of the jagged matrix
            foreach (int[] row in jagged)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
