using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_OOP
{
   public  class Mainn
   {
        static public void Main(String[] args)
        {
            Author author1 = new Author("Fedor", "Dostoevskiy");
            Author author2 = new Author("Lev", "Tolstoi");
            Author author3 = new Author("Nick", "Gogol");

            Book book1 = new Book(author1, "Prestuplenie", "long text here");
            Book book2 = new Book(author2, "Voina", "the longest text here");
            Book book3 = new Book(author3, "Revizor", "longer text here");

            List<Book> books = new List<Book>();
            books.Add(book1);
            books.Add(book2);
            books.Add(book3);

            Library library = new Library(books);

            Console.WriteLine("Thi library has such books: ");
            foreach (Book b in library.Books)
            {
                Console.WriteLine(b.ToString());
            }
        }
    }
}
