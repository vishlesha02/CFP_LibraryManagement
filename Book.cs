using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Book
    {
        
            public int Book_id;

            public string Title;

            public string Author;

            public string Genre;

            public bool Borrowed;


        public Book()
        { }

        public Book(int bookid, string title, string author, string genre, bool borrowed) 
        {
            Book_id=bookid;
            Title = title;
            Author= author;
            Genre= genre;
            Borrowed= borrowed;

        }
    }
}
