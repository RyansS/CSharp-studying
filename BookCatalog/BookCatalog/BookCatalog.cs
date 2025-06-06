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

        public Book this[string ISBN]
        {
            get
            {
                if (catalog.ContainsKey(ISBN))
                {
                    return catalog[ISBN];
                }
                else
                {
                    return null;
                }
            }
        }

        public void AddBook(Book Book)
        {
            catalog[Book.ISBN] = Book;
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


            return new Book(ISBN, title, author, numbOfPages);
        }

        public void ShowBooks()
        {
            Console.Clear();
            Console.WriteLine($"Total of titles in our catalog: {catalog.Count}");

            foreach (var allbooks in catalog.Values)
            {
                allbooks.ToString();
            }
        }

        public void RemoveBook()
        {
            ShowBooks();
            Console.WriteLine("\n");

            Console.Write("Which title you'd like to remove? ");
            var answer = Console.ReadLine();

            string isbnToRemove = null;

            foreach (var entry in catalog)
            {
                if (entry.Value.title.ToLower() == answer.ToLower())
                {
                    isbnToRemove = entry.Key;
                    break;
                }

                if (isbnToRemove != null)
                {
                    catalog.Remove(isbnToRemove);
                    Console.WriteLine($"Title removed!");
                }
                else
                {
                    Console.WriteLine("Book not found.");
                }
            }
        }
    }

}
