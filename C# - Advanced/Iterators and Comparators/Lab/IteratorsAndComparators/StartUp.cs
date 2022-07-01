using System;
using System.Linq;

namespace IteratorsAndComparators
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            // PROBLEM 01. Library:
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);

            Library libraryOne = new Library();
            Library libraryTwo = new Library(bookOne, bookTwo, bookThree);

            // PROBLEM 02. LibraryIterator:
            //foreach (var book in libraryTwo)
            //{
            //    Console.WriteLine(book.Title);
            //}

            // PROBLEM 03. ComparableBook:
            //foreach (var book in libraryTwo)
            //{
            //    Console.WriteLine(book);
            //}

            // PROBLEM 04. BookComparer:
            var sortedLib = libraryTwo.ToArray();
            Array.Sort(sortedLib, new BookComparator());

            foreach (var book in sortedLib)
            {
                Console.WriteLine(book);
            }
        }
    }
}
