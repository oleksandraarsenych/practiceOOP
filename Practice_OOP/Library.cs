using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_OOP
{
    public class Library
    {
        public List<Book> Books { get; }

        public Library(List<Book> books) 
        {
            this.Books = books;
        }

    }
}
