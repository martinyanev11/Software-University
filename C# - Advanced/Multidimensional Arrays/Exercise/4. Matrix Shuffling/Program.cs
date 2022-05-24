using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize matrix and fill data
            int[] matrixDimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = matrixDimensions[0];
            int columns = matrixDimensions[1];

            string[,] matrix = new string[rows, columns];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowData = Console.ReadLine().Split();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            string tempValueHolder = string.Empty;
            
            // Check if input is correctly given and execute it accordingly
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                bool inputIsLegit = true;

                string[] cmdArgs = input.Split();
                if (cmdArgs[0] == "swap")
                {
                    if (cmdArgs.Length == 5)
                    {
                        int r1 = int.Parse(cmdArgs[1]);
                        int c1 = int.Parse(cmdArgs[2]);

                        int r2 = int.Parse(cmdArgs[3]);
                        int c2 = int.Parse(cmdArgs[4]);

                        if (r1 >= 0 && r1 < rows && c1 >= 0 && c1 <= columns &&
                            r2 >= 0 && r2 < rows && c2 >= 0 && c2 <= columns)
                        {
                            tempValueHolder = matrix[r1, c1];
                            matrix[r1, c1] = matrix[r2, c2];
                            matrix[r2, c2] = tempValueHolder;

                            // Print the matrix after each successful change
                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix.GetLength(1); col++)
                                {
                                    Console.Write($"{matrix[row, col]} ");
                                }
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            inputIsLegit = false;
                        }
                    }
                    else
                    {
                        inputIsLegit = false;
                    }
                }
                else
                {
                    inputIsLegit = false;
                }

                if (!inputIsLegit)
                {
                    Console.WriteLine("Invalid input!");  
                }
            }
        }
    }
}
