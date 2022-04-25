using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            int bookCounter = 0;
            string search = Console.ReadLine();

            while (book != search)
            {
                search = Console.ReadLine();
                bookCounter++;

                if (search == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {bookCounter} books.");
                    break;
                }
            }

            if (book == search)
            {
                Console.WriteLine($"You checked {bookCounter} books and found it.");
            }
        }
    }
}
