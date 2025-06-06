using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        

        public string ISBN;
        public string title;
        public string author;
        public int numbOfPages;
        
        public Book (string ISBN, string title, string author, int numbOfPages)
        {
            this.ISBN = ISBN;
            this.title = title;
            this.author = author;
            this.numbOfPages = numbOfPages;
        }

        public override string ToString()
        {
            return $"Title: {title}\n Author: {author}\n Pages: {numbOfPages}\n ISBN: {ISBN}";
        }


    }

    class BookCatalog
    {
        private Dictionary<string, Book> catalog = new Dictionary<string, Book>();

        public void AddBook(Book newBook)
        {
            catalog[newBook.ISBN] = newBook;
        }

        public static Book CreateBook()
        {
            Console.Clear();

            Console.Write("Which book are you going to add? ");
            var title = Console.ReadLine();

            Console.Write("\nWhat's it's author? ");
            var author = Console.ReadLine();

            Random numbPages = new();
            int numbOfPages = numbPages.Next(20, 500);

            Random ISBNrandom = new();
            int ISBNint = ISBNrandom.Next(100000, 900000);
            string ISBN = Convert.ToString(ISBNint);

            Book newBook = CreateBook();
            return new Book(ISBN, title, author, numbOfPages);
        }

        public void ShowBooks()
        {
            Console.Clear();
            Console.WriteLine($"Total of title in our catalog: {catalog.Count}");

            foreach (var allbooks in catalog.Values)
            {
                allbooks.ToString();
            }
        }
    }

}
