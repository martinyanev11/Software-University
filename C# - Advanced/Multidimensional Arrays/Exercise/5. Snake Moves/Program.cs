using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int columns = dimensions[1];

            char[,] matrix = new char[rows, columns];

            string snake = Console.ReadLine();
            int currSnakeIndex = 0;

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0) // if row is even number fill letter from left to right
                {
                    for (int col = 0; col < columns; col++)
                    {
                        matrix[row, col] = snake[currSnakeIndex];
                        currSnakeIndex++;
                        if (currSnakeIndex == snake.Length)
                        {
                            currSnakeIndex = 0;
                        }
                    }
                }
                else // else fill letter from right to left
                {
                    for (int col = columns - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snake[currSnakeIndex];
                        currSnakeIndex++;
                        if (currSnakeIndex == snake.Length)
                        {
                            currSnakeIndex = 0;
                        }
                    }
                }
            }

            // Print the matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
