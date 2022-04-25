using System;

namespace _06._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floorsTotal = int.Parse(Console.ReadLine());
            int roomsPerFloor = int.Parse(Console.ReadLine());

            // odd floors are only filled with apartments (A)
            // even floors are only filled with offices (O)
            // last floor of the building has large apartments (L)
            char indexLetter;

            for (int floor = floorsTotal; floor > 0; floor--)
            {
                if (floor == floorsTotal)
                {
                    indexLetter = 'L';
                }
                else if (floor % 2 == 0)
                {
                    indexLetter = 'O';
                }
                else
                {
                    indexLetter = 'A';
                }
                for (int room = 0; room < roomsPerFloor; room++)
                {
                    Console.Write($"{indexLetter}{floor}{room} ");
                }
                Console.WriteLine();
            }
        }
    }
}
