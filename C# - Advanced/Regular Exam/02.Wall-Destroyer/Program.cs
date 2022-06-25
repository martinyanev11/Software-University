using System;
using System.Linq;

namespace _02.Wall_Destroyer
{
    class Program
    {
        static void Main(string[] args)
        {
            int wallSize = int.Parse(Console.ReadLine());
            char[,] wall = new char[wallSize, wallSize];
            int[] vankoCoordinates = new int[2];

            CreateWall(wall, vankoCoordinates);

            int holesMadeCounter = 0;

            string command;
            bool isElectrocuted = false;
            while ((command = Console.ReadLine()) != "End")
            {
                if (VankoCanMove(wall, vankoCoordinates, command))
                {
                    switch (command)
                    {
                        case "up":
                            vankoCoordinates[0] -= 1; // Vanko moves
                            wall[vankoCoordinates[0] + 1, vankoCoordinates[1]] = '*';
                            holesMadeCounter++;

                            if (IsElectrocuted(wall, vankoCoordinates))
                            {
                                isElectrocuted = true;
                                holesMadeCounter++;
                                wall[vankoCoordinates[0], vankoCoordinates[1]] = 'E';
                                break;
                            }
                            else if (HitsRod(wall, vankoCoordinates))
                            {
                                Console.WriteLine("Vanko hit a rod!");
                                vankoCoordinates[0] += 1; // Vanko moves back

                                if (PossitionHasHole(wall, vankoCoordinates))
                                {
                                    Console.WriteLine($"The wall is already destroyed at position {wall[vankoCoordinates[0], vankoCoordinates[1]]}!");
                                }
                            }
                            else if (PossitionHasHole(wall, vankoCoordinates))
                            {
                                Console.WriteLine($"The wall is already destroyed at position {wall[vankoCoordinates[0], vankoCoordinates[1]]}!");
                            }
                            else
                            {
                                if (wall[vankoCoordinates[0], vankoCoordinates[1]] == '-')
                                {
                                    wall[vankoCoordinates[0], vankoCoordinates[1]] = '*';
                                    holesMadeCounter++;
                                }
                            }
                            break;

                        case "down":
                            vankoCoordinates[0] += 1; // Vanko moves
                            wall[vankoCoordinates[0] - 1, vankoCoordinates[1]] = '*';
                            holesMadeCounter++;

                            if (IsElectrocuted(wall, vankoCoordinates))
                            {
                                isElectrocuted = true;
                                holesMadeCounter++;
                                wall[vankoCoordinates[0], vankoCoordinates[1]] = 'E';
                                break;
                            }
                            else if (HitsRod(wall, vankoCoordinates))
                            {
                                Console.WriteLine("Vanko hit a rod!");
                                vankoCoordinates[0] -= 1; // Vanko moves back

                                if (PossitionHasHole(wall, vankoCoordinates))
                                {
                                    Console.WriteLine($"The wall is already destroyed at position {wall[vankoCoordinates[0], vankoCoordinates[1]]}!");
                                }
                            }
                            else if (PossitionHasHole(wall, vankoCoordinates))
                            {
                                Console.WriteLine($"The wall is already destroyed at position {wall[vankoCoordinates[0], vankoCoordinates[1]]}!");
                            }
                            else
                            {
                                if (wall[vankoCoordinates[0], vankoCoordinates[1]] == '-')
                                {
                                    wall[vankoCoordinates[0], vankoCoordinates[1]] = '*';
                                    holesMadeCounter++;
                                }
                            }
                            break;

                        case "left":
                            vankoCoordinates[1] -= 1; // Vanko moves
                            wall[vankoCoordinates[0] + 1, vankoCoordinates[1]] = '*';
                            holesMadeCounter++;

                            if (IsElectrocuted(wall, vankoCoordinates))
                            {
                                isElectrocuted = true;
                                holesMadeCounter++;
                                wall[vankoCoordinates[0], vankoCoordinates[1]] = 'E';
                                break;
                            }
                            else if (HitsRod(wall, vankoCoordinates))
                            {
                                Console.WriteLine("Vanko hit a rod!");
                                vankoCoordinates[1] += 1; // Vanko moves back

                                if (PossitionHasHole(wall, vankoCoordinates))
                                {
                                    Console.WriteLine($"The wall is already destroyed at position {wall[vankoCoordinates[0], vankoCoordinates[1]]}!");
                                }
                            }
                            else if (PossitionHasHole(wall, vankoCoordinates))
                            {
                                Console.WriteLine($"The wall is already destroyed at position {wall[vankoCoordinates[0], vankoCoordinates[1]]}!");
                            }
                            else
                            {
                                if (wall[vankoCoordinates[0], vankoCoordinates[1]] == '-')
                                {
                                    wall[vankoCoordinates[0], vankoCoordinates[1]] = '*';
                                    holesMadeCounter++;
                                }
                            }
                            break;

                        case "right":
                            vankoCoordinates[1] += 1; // Vanko moves
                            wall[vankoCoordinates[0] - 1, vankoCoordinates[1]] = '*';
                            holesMadeCounter++;

                            if (IsElectrocuted(wall, vankoCoordinates))
                            {
                                isElectrocuted = true;
                                holesMadeCounter++;
                                wall[vankoCoordinates[0], vankoCoordinates[1]] = 'E';
                                break;
                            }
                            else if (HitsRod(wall, vankoCoordinates))
                            {
                                Console.WriteLine("Vanko hit a rod!");
                                vankoCoordinates[1] -= 1; // Vanko moves back

                                if (PossitionHasHole(wall, vankoCoordinates))
                                {
                                    Console.WriteLine($"The wall is already destroyed at position {wall[vankoCoordinates[0], vankoCoordinates[1]]}!");
                                }
                            }
                            else if (PossitionHasHole(wall, vankoCoordinates))
                            {
                                Console.WriteLine($"The wall is already destroyed at position {wall[vankoCoordinates[0], vankoCoordinates[1]]}!");
                            }
                            else
                            {
                                if (wall[vankoCoordinates[0], vankoCoordinates[1]] == '-')
                                {
                                    wall[vankoCoordinates[0], vankoCoordinates[1]] = '*';
                                    holesMadeCounter++;
                                }
                            }
                            break;
                    }
                }

                if (isElectrocuted)
                {
                    Console.WriteLine($"Vanko got electrocuted, but he managed to make {holesMadeCounter} hole(s).");
                    break;
                }
            }

            if (!isElectrocuted)
            {
                wall[vankoCoordinates[0], vankoCoordinates[1]] = 'V';
            }
             
            for (int row = 0; row < wall.GetLength(0); row++)
            {
                for (int col = 0; col < wall.GetLength(1); col++)
                {
                    Console.Write(wall[row, col]);
                }
                Console.WriteLine();
            }

            static bool VankoCanMove(char[,] wall, int[] vankoCoordinates, string command)
            {
                switch (command)
                {
                    case "up":
                        if (vankoCoordinates[0] - 1 >= 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    case "down":
                        if (vankoCoordinates[0] + 1 < wall.GetLength(0))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    case "left":
                        if (vankoCoordinates[1] - 1 >= 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    case "right":
                        if (vankoCoordinates[1] + 1 < wall.GetLength(1))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                }
                return false;
            }

            static void CreateWall(char[,] wall, int[] vankoCoordinates)
            {
                for (int row = 0; row < wall.GetLength(0); row++)
                {
                    string rowData = Console.ReadLine();
                    for (int col = 0; col < wall.GetLength(1); col++)
                    {
                        wall[row, col] = rowData[col];
                        if (rowData[col] == 'P')
                        {
                            vankoCoordinates[0] = row;
                            vankoCoordinates[1] = col;
                        }
                    }
                }
            }

            static bool IsElectrocuted(char[,] wall, int[] vankoCoordinates)
            {
                if (wall[vankoCoordinates[0], vankoCoordinates[1]] == 'C')
                {
                    return true;
                }
                return false;
            }

            static bool HitsRod(char[,] wall, int[] vankoCoordinates)
            {
                if (wall[vankoCoordinates[0], vankoCoordinates[1]] == 'R')
                {
                    return true;
                }
                return false;
            }

            static bool PossitionHasHole(char[,] wall, int[] vankoCoordinates)
            {
                if (wall[vankoCoordinates[0], vankoCoordinates[1]] == '*')
                {
                    return true;
                }
                return false;
            }
        }
    }
}
