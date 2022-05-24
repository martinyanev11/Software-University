using System;
using System.Linq;
using System.Collections.Generic;

namespace _7._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int boardSize = int.Parse(Console.ReadLine());

            char[,] board = new char[boardSize, boardSize];

            for (int row = 0; row < board.GetLength(0); row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < board.GetLength(1); col++)
                {
                    board[row, col] = input[col];
                }
            }

            int removedKnightsCount = 0;


            while (true)
            {
                int maxAttack = 0;
                int rowAttackIndex = 0;
                int colAttackIndex = 0;

                for (int row = 0; row < board.GetLength(0); row++)
                {

                    for (int col = 0; col < board.GetLength(1); col++)
                    {
                        if (board[row, col] == '0')
                        {
                            continue;
                        }

                        int currentAttacks = 0;

                        if (isInRange(board, row - 2, col - 1) && board[row - 2, col - 1] == 'K')
                        {
                            currentAttacks++;
                        }

                        if (isInRange(board, row - 2, col + 1) && board[row - 2, col + 1] == 'K')
                        {
                            currentAttacks++;
                        }

                        if (isInRange(board, row - 1, col - 2) && board[row - 1, col - 2] == 'K')
                        {
                            currentAttacks++;
                        }

                        if (isInRange(board, row + 1, col - 2) && board[row + 1, col - 2] == 'K')
                        {
                            currentAttacks++;
                        }

                        if (isInRange(board, row + 1, col + 2) && board[row + 1, col + 2] == 'K')
                        {
                            currentAttacks++;
                        }

                        if (isInRange(board, row - 1, col + 2) && board[row - 1, col + 2] == 'K')
                        {
                            currentAttacks++;
                        }

                        if (isInRange(board, row + 2, col + 1) && board[row + 2, col + 1] == 'K')
                        {
                            currentAttacks++;
                        }

                        if (isInRange(board, row + 2, col - 1) && board[row + 2, col - 1] == 'K')
                        {
                            currentAttacks++;
                        }

                        if (currentAttacks > maxAttack)
                        {
                            maxAttack = currentAttacks;
                            rowAttackIndex = row;
                            colAttackIndex = col;
                        }
                    }
                }

                if (maxAttack > 0)
                {
                    board[rowAttackIndex, colAttackIndex] = '0';
                    removedKnightsCount++;
                }
                else
                {
                    Console.WriteLine(removedKnightsCount);
                    break;
                }
            }
        }

        private static bool isInRange(char[,] board, int row, int col)
        {
            return row >= 0 && row < board.GetLength(0) && col >= 0 && col < board.GetLength(1);
        }
    }    
}
