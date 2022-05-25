using System;
using System.Linq;
using System.Collections.Generic;

namespace _9._Miner
{
    class Program
    {
        private static bool MoveCheckAndExecute(char[,] field, int[] playerCoordinates, string movementDirection)
        {
            switch (movementDirection)
            {
                case "up": // check if above row isn't out of the field boundry
                    if (playerCoordinates[0] - 1 >= 0)
                    {
                        playerCoordinates[0] -= 1;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "down": // check if below row isn't out of the field boundry
                    if (playerCoordinates[0] + 1 < field.GetLength(0))
                    {
                        playerCoordinates[0] += 1;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "left": // check if left column isn't out of the field boundry
                    if (playerCoordinates[1] - 1 >= 0)
                    {
                        playerCoordinates[1] -= 1;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "right": // check if right column isn't out of the field boundry
                    if (playerCoordinates[1] + 1 < field.GetLength(1))
                    {
                        playerCoordinates[1] += 1;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
            }

            return false;
        }

        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            char[,] field = new char[fieldSize, fieldSize];

            // Load the commands in queue
            string[] cmdArgs = Console.ReadLine().Split();
            Queue<string> commands = new Queue<string>();
            for (int i = 0; i < cmdArgs.Length; i++)
            {
                commands.Enqueue(cmdArgs[i]);
            }

            // Initialize the play field with it's properties
            int coalsRemaining = 0;
            int[] playerCoordinates = new int[2];

            for (int row = 0; row < fieldSize; row++)
            {
                char[] rowData = Console.ReadLine().Split().Select(char.Parse).ToArray();

                for (int col = 0; col < fieldSize; col++)
                {
                    field[row, col] = rowData[col];
                    if (rowData[col] == 'c')
                    {
                        coalsRemaining++;
                    }
                    if (rowData[col] == 's') // that is the starting possition of the player
                    {
                        playerCoordinates[0] = row;
                        playerCoordinates[1] = col;
                    }
                }
            }

            // Execute commands accordingly
            bool gameOver = false;
            bool coalsCollected = false;
            while (commands.Count > 0)
            {
                string nextCommand = commands.Peek();
                if (MoveCheckAndExecute(field, playerCoordinates, nextCommand))
                {
                    if (field[playerCoordinates[0], playerCoordinates[1]] == 'e')
                    {
                        Console.WriteLine($"Game over! ({playerCoordinates[0]}, {playerCoordinates[1]})");
                        gameOver = true;
                        break;
                    }
                    else if (field[playerCoordinates[0], playerCoordinates[1]] == 'c')
                    {
                        field[playerCoordinates[0], playerCoordinates[1]] = '*';
                        coalsRemaining--;
                        if (coalsRemaining == 0)
                        {
                            Console.WriteLine($"You collected all coals! ({playerCoordinates[0]}, {playerCoordinates[1]})");
                            coalsCollected = true;
                            break;
                        }
                    }
                }
                commands.Dequeue();
            }

            if (gameOver == false && coalsCollected == false)
            {
                Console.WriteLine($"{coalsRemaining} coals left. ({playerCoordinates[0]}, {playerCoordinates[1]})");
            }
        }


    }
}
