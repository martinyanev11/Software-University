using System;
using System.Linq;

namespace _10._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladybugPosittionsArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] field = new int[fieldSize];

            foreach (int ladybugPosition in ladybugPosittionsArray)
            {
                for (int i = 0; i < fieldSize; i++)
                {
                    if (i == ladybugPosition)
                    {
                        field[i] = 1;
                    }

                }
            }
            bool isEnded = false;

            while (isEnded == false)
            {
                string possitionChangeCommand = Console.ReadLine();
                if (possitionChangeCommand == "end")
                {
                    isEnded = true;
                }
                else
                {
                    // UNDERSTANDING THE COMMAND GIVEN
                    string[] commandReading = possitionChangeCommand.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    int ladybugStartingIndex = int.Parse(commandReading[0]);
                    string ladybugMovementDirection = commandReading[1];
                    int ladybugFlyLength = int.Parse(commandReading[2]);

                    // EXECUTING THE COMMAND GIVEN
                    if (field[ladybugStartingIndex - ladybugFlyLength] >= 0 && field[ladybugStartingIndex + ladybugFlyLength] < fieldSize)
                    {
                        if (field[ladybugStartingIndex] == 1) // IF THERE IS LADYBUG IN INDEX
                        {
                            field[ladybugStartingIndex] = 0; // IT FLIES AWAY

                            // DETERMINE THE DIRECTION
                            if (ladybugMovementDirection == "right")
                            {
                                if (ladybugStartingIndex + ladybugFlyLength < fieldSize)
                                {
                                    if (field[ladybugStartingIndex + ladybugFlyLength] != 1)
                                    {
                                        field[ladybugStartingIndex + ladybugFlyLength] = 1;
                                    }
                                    else if (field[ladybugStartingIndex + ladybugFlyLength] == 1)
                                    {
                                        for (int i = ladybugStartingIndex; i < fieldSize - 1; i += ladybugFlyLength)
                                        {
                                            if (field[i + ladybugFlyLength] != 1)
                                            {
                                                field[i + ladybugFlyLength] = 1;
                                            }
                                        }
                                    }
                                }
                            }
                            else if (ladybugMovementDirection == "left")
                            {
                                if (ladybugStartingIndex - ladybugFlyLength >= 0)
                                {
                                    field[ladybugStartingIndex - ladybugFlyLength] = 1;
                                    if (field[ladybugStartingIndex - ladybugFlyLength] != 1)
                                    {
                                        field[ladybugStartingIndex - ladybugFlyLength] = 1;
                                    }
                                    else if (field[ladybugStartingIndex - ladybugFlyLength] == 1)
                                    {
                                        for (int i = ladybugStartingIndex; i == 0; i -= ladybugFlyLength)
                                        {
                                            if (field[i - ladybugFlyLength] != 1)
                                            {
                                                field[i - ladybugFlyLength] = 1;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
