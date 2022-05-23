using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reading a jagged array from console
            int rowCount = int.Parse(Console.ReadLine());
            int[][] jaggedMatrix = new int[rowCount][];

            for (int row = 0; row < jaggedMatrix.Length; row++)
            {
                int[] newRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedMatrix[row] = new int[newRow.Length];

                for (int col = 0; col < jaggedMatrix[row].Length; col++)
                {
                    jaggedMatrix[row][col] = newRow[col];
                }
            }

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                // Executing commands
                string[] cmdArgs = input.Split();
                string commandType = cmdArgs[0];
                int rowToChange = int.Parse(cmdArgs[1]);
                int colToChange = int.Parse(cmdArgs[2]);
                int value = int.Parse(cmdArgs[3]);

                if (rowToChange >= 0 && rowToChange < jaggedMatrix.Length)
                {
                    if (colToChange >= 0 && colToChange < jaggedMatrix[rowToChange].Length)
                    {
                        if (commandType == "Add")
                        {
                            jaggedMatrix[rowToChange][colToChange] += value;
                        }
                        else if (commandType == "Subtract")
                        {
                            jaggedMatrix[rowToChange][colToChange] -= value;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
            }

            // Printing the matrix on the console
            foreach (int[] row in jaggedMatrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
            
        }
    }
}
