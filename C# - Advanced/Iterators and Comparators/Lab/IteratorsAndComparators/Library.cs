using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        public Library(params Book[] books)
        {
            this.books = books.ToList();
        }

        private List<Book> books { get; set; }

        public IEnumerator<Book> GetEnumerator()
        {
            this.books.ToList();
            for (int i = 0; i < books.Count; i++)
            {
                yield return books[i];
            }
            //return new LibraryIterator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        // Long way to do it

        //class LibraryIterator : IEnumerator<Book>
        //{
        //    private List<Book> books;
        //    private int position;

        //    public LibraryIterator(List<Book> books)
        //    {
        //        this.books = books;
        //        Reset();
        //    }

        //    public Book Current => this.books[position];

        //    object IEnumerator.Current => this.Current;

        //    public void Dispose()
        //    {
        //        // Not needed
        //    }

        //    public bool MoveNext()
        //    {
        //        this.position++;
        //        return position < this.books.Count;
        //    }

        //    public void Reset()
        //    {
        //        this.position = -1;
        //    }
        //}
    }
}
