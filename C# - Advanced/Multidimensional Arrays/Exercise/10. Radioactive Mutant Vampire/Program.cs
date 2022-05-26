using System;
using System.Linq;
using System.Collections.Generic;

namespace _10._Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the playing field with it's properties
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int columns = dimensions[1];

            char[,] field = new char[rows, columns];
            int[] playerCoordinates = new int[2];
            InitializeBunnyLair(field, playerCoordinates);

            // Load a queue of commands to be executed
            string cmdArgs = Console.ReadLine();
            Queue<char> command = new Queue<char>(cmdArgs);

            // Start game
            bool steppedOnBunny = false;
            bool playerWon = false;
            while (command.Count != 0)
            {
                char nextCommand = command.Dequeue();

                // Check if player remains in the lair after moving
                if (PlayerMove(field, playerCoordinates, nextCommand)) // Game continues
                {
                    //Check if player stepped on buddy after his move
                    if (SteppedOnBunnyCheck(field, playerCoordinates))
                    {
                        steppedOnBunny = true;
                    }
                    BunniesMultiplication(field);
                    if (steppedOnBunny == true)
                    {
                        break;
                    }
                    // Check if bunny spawned on player location index after multiplication
                    if (SteppedOnBunnyCheck(field, playerCoordinates))
                    {
                        steppedOnBunny = true;
                        break;
                    }
                }
                else // Player won
                {
                    playerWon = true;
                    BunniesMultiplication(field);
                    PlayerWonMessage(field, playerCoordinates);
                    break;
                }
            }

            if (steppedOnBunny == true && playerWon == false)
            {
                PlayerLostMessage(field, playerCoordinates);
            }

        }

        private static void PlayerWonMessage(char[,] field, int[] playerCoordinates)
        {
            //field[playerCoordinates[0], playerCoordinates[1]] = '.'; // replace 'P' with '.'

            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    Console.Write(field[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine($"won: {playerCoordinates[0]} {playerCoordinates[1]}");
        }

        private static void PlayerLostMessage(char[,] field, int[] playerCoordinates)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    Console.Write(field[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine($"dead: {playerCoordinates[0]} {playerCoordinates[1]}");
        }

        private static void InitializeBunnyLair(char[,] field, int[] playerCoordinates)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                string rowData = Console.ReadLine();
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = rowData[col];
                    if (rowData[col] == 'P')
                    {
                        playerCoordinates[0] = row;
                        playerCoordinates[1] = col;
                        field[playerCoordinates[0], playerCoordinates[1]] = '.'; // replace 'P' with '.'
                    }
                }
            }
        }

        private static void BunniesMultiplication(char[,] field)
        {
            // Find initial bunny coordinates
            Queue<int[]> allBunnyCoordinates = new Queue<int[]>();
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row, col] == 'B')
                    {
                        allBunnyCoordinates.Enqueue(new int[] { row, col });
                    }
                }
            }

            // Multiply each bunny to all nearby legit indexes
            //for (int i = 0; i < allBunnyCoordinates.Count; i++)
            while (allBunnyCoordinates.Count != 0)
            {
                int[] currentBunnyCoordinates = allBunnyCoordinates.Dequeue();
                int bunnyRow = currentBunnyCoordinates[0];
                int bunnyCol = currentBunnyCoordinates[1];

                // Replace all indexes within the lair with 'B'
                MultiplicationProcess(field, bunnyRow, bunnyCol);
            }
        }

        private static void MultiplicationProcess(char[,] field, int row, int col)
        {
            //if (row - 1 >= 0 && col - 1 >= 0) //#1 top left
            //{
            //    field[row - 1, col - 1] = 'B';
            //}

            if (col - 1 >= 0) //#2 left
            {
                field[row, col - 1] = 'B';
            }

            //if (row + 1 < field.GetLength(0) && col - 1 >= 0) // #3 bottom left
            //{
            //    field[row + 1, col - 1] = 'B';
            //}

            if (row - 1 >= 0) //#4 top
            {
                field[row - 1, col] = 'B';
            }

            if (row + 1 < field.GetLength(0)) //#5 bottom
            {
                field[row + 1, col] = 'B';
            }

            //if (row - 1 >= 0 && col + 1 < field.GetLength(1)) //#6 top right
            //{
            //    field[row - 1, col + 1] = 'B';
            //}

            if (col + 1 < field.GetLength(1)) //#7 right
            {
                field[row, col + 1] = 'B';
            }

            //if (row + 1 < field.GetLength(0) && col + 1 < field.GetLength(1)) //#8 bottom right
            //{
            //    field[row + 1, col + 1] = 'B';
            //}
        }

        private static bool SteppedOnBunnyCheck(char[,] field, int[] playerCoordinates)
        {
            if (field[playerCoordinates[0], playerCoordinates[1]] == 'B')
            {
                return true;
            }
            return false;
        }

        private static bool PlayerMove(char[,] field, int[] playerCoordinates, char movementDirection)
        {
            switch (movementDirection)
            {
                case 'U': // up movement
                    if (playerCoordinates[0] - 1 >= 0)
                    {
                        playerCoordinates[0] -= 1;
                        return true; // player moves & game continues
                    }
                    else
                    {
                        return false; // player leaves the lair and wins the game
                    }

                case 'D': // down movement
                    if (playerCoordinates[0] + 1 < field.GetLength(0))
                    {
                        playerCoordinates[0] += 1;
                        return true; // player moves & game continues
                    }
                    else
                    {
                        return false; // player leaves the lair and wins the game
                    }

                case 'L': // left movement
                    if (playerCoordinates[1] - 1 >= 0)
                    {
                        playerCoordinates[1] -= 1;
                        return true; // player moves & game continues
                    }
                    else
                    {
                        return false; // player leaves the lair and wins the game
                    }

                case 'R': // right movement
                    if (playerCoordinates[1] + 1 < field.GetLength(1))
                    {
                        playerCoordinates[1] += 1;
                        return true; // player moves & game continues
                    }
                    else
                    {
                        return false; // player leaves the lair and wins the game
                    }
            }
            return false;
        }
    }
}
