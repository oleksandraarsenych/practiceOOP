using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_OOP
{
    public class Book
    {
        public Author Author { get; }
        public string Name { get; }
        public string Text { get; private set; }

        public Book(Author Author, string Name, string Text)
        {
            this.Author = Author;
            this.Name = Name;
            this.Text = Text;
        }
        public override string ToString()
        {
            return Name + " " + Author.ToString();
        }
    }
}
