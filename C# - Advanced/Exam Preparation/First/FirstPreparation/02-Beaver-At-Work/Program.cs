using System;
using System.Linq;
using System.Collections.Generic;

namespace _02_Beaver_At_Work
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine()); // size of the pond

            char[,] matrix = new char[size, size];
            int branchesTotalCount = 0;
            int[] beaverCoordinates = new int[2];

            Stack<char> collectedBranches = new Stack<char>();

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    char[] input = Console.ReadLine().Split().Select(char.Parse).ToArray();
                    matrix[row, col] = input[col];

                    if (char.IsLower(input[col])) // count the number of branches
                    {
                        branchesTotalCount++;
                    }
                    if (input[col] == 'B') // get the initial beaver possition
                    {
                        beaverCoordinates[0] = row;
                        beaverCoordinates[1] = col;
                    }
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                BeaverMoves(matrix, command, beaverCoordinates, collectedBranches, branchesTotalCount);
            }
        }

        private static void BeaverMoves(char[,] matrix, string command, int[] beaverCoordinates, 
            Stack<char> collectedBranches, int branchesTotalCount)
        {
            switch (command)
            {
                case "up":
                    if (beaverCoordinates[0] - 1 >= 0)
                    {
                        if (matrix[beaverCoordinates[0] - 1, beaverCoordinates[1]] == '-')
                        {
                            matrix[beaverCoordinates[0] - 1, beaverCoordinates[1]] = 'B';
                            matrix[beaverCoordinates[0], beaverCoordinates[1]] = '-';

                            beaverCoordinates[0] -= 1;
                        }
                        else if (char.IsLower(matrix[beaverCoordinates[0] - 1, beaverCoordinates[1]]))
                        {
                            collectedBranches.Push(matrix[beaverCoordinates[0] - 1, beaverCoordinates[1]]);
                            branchesTotalCount--;

                            matrix[beaverCoordinates[0] - 1, beaverCoordinates[1]] = 'B';
                            matrix[beaverCoordinates[0], beaverCoordinates[1]] = '-';

                            beaverCoordinates[0] -= 1;
                        }
                        else if (matrix[beaverCoordinates[0] - 1, beaverCoordinates[1]] == 'F')
                        {
                            BeaverSwims(matrix, command, beaverCoordinates, collectedBranches, branchesTotalCount);
                        }
                    }
                    break;

                case "down":
                    break;

                case "left":
                    break;

                case "right":
                    break;
            }
        }

        private static void BeaverSwims(char[,] matrix, string command, int[] beaverCoordinates, 
            Stack<char> collectedBranches, int branchesTotalCount)
        {
            
        }
    }
}
