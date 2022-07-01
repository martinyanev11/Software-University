using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IteratorsAndComparators
{
    public class BookComparator : IComparer<Book>
    {
        public int Compare(Book bookOne, Book bookTwo)
        {
            int result = bookOne.Title.CompareTo(bookTwo.Title);
            if (result == 0)
            {
                result = bookTwo.Year.CompareTo(bookOne.Year);
            }
            return result;
        }
    }
}
