using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineLibraryApp
{
    // proprietes of books
    public class Books
    {
        public string CallNumber { get; set; }
    }

    // list of library books
    public class BookList
    {
        public List<Books> LibraryBooks { get; set; }

        // constructor
        public BookList()
        {
            this.LibraryBooks = new List<Books>();
        }
    }
}
