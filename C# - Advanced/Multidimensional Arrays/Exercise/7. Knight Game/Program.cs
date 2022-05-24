using System;
using System.Linq;
using System.Collections.Generic;

namespace _7._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the square chess board (matrix) filled with knights
            int boardSize = int.Parse(Console.ReadLine());
            char[,] board = new char[boardSize, boardSize];

            for (int row = 0; row < boardSize; row++)
            {
                string rowInput = Console.ReadLine().Trim();
                char[] rowArray = new char[rowInput.Length];
                for (int i = 0; i < rowInput.Length; i++)
                {
                    rowArray[i] = rowInput[i];
                }
                for (int col = 0; col < boardSize; col++)
                {
                    board[row, col] = rowArray[col];
                }
            }

            int removedKnightsCounter = 0;

            // Check for colliding knights
            for (int r = 0; r < boardSize - 1; r++)
            {
                for (int c = 0; c < boardSize; c++)
                {
                    if (board[r,c] == 'K') // Check if we have knight in current matrix index
                    {
                        // Check #1 for collision
                        if (c - 2 >= 0 && c - 2 < boardSize)
                        {
                            if (r + 1 >= 0 && r + 1 < boardSize)
                            {
                                if (board[r, c] == board[r + 1, c - 2])
                                {
                                    board[r + 1, c - 2] = '0';
                                    removedKnightsCounter++;
                                    //continue;
                                }
                            }
                        }

                        // Check #2 for collision
                        if (c - 1 >= 0 && c - 1 < boardSize)
                        {
                            if (r + 2 >= 0 && r + 2 < boardSize)
                            {
                                if (board[r, c] == board[r + 2, c - 1])
                                {
                                    board[r + 2, c - 1] = '0';
                                    removedKnightsCounter++;
                                    //continue;
                                }
                            }
                        }

                        // Check #3 for collision
                        if (c + 1 >= 0 && c + 1 < boardSize)
                        {
                            if (r + 2 >= 0 && r + 2 < boardSize)
                            {
                                if (board[r, c] == board[r + 2, c + 1])
                                {
                                    board[r + 2, c + 1] = '0';
                                    removedKnightsCounter++;
                                    //continue;
                                }
                            }
                            
                        }

                        // Check #4 for collision
                        if (c + 2 >= 0 && c + 2 < boardSize)
                        {
                            if (r + 1 >= 0 && r + 1 < boardSize)
                            {
                                if (board[r, c] == board[r + 1, c + 2])
                                {
                                    board[r + 1, c + 2] = '0';
                                    removedKnightsCounter++;
                                    //continue;
                                }
                            } 
                        }
                    }
                    
                }
            }

            Console.WriteLine(removedKnightsCounter);
        }
    }
}
