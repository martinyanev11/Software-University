using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace IteratorsAndComparators
{
    public class Library
    {
        public Library(params Book[] books)
        {
            this.books = books.ToList();
        }

        private List<Book> books { get; set; }
    }
}
