
using Library;
using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        BookCatalog catalog = new BookCatalog();


        Menu("Welcome to the library!");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                Book newBook = BookCatalog.CreateBook();
                    catalog.AddBook(newBook);
                    catalog.ShowBooks();
                break;

                case "2":
                    catalog.ShowBooks();
                    break;

                case "3": break;
                case "4": break;
                case "5": break;
            }
    }
    public static void Menu(string v)
    {
        Console.Clear();
        Console.WriteLine("1 - Add a book");
        Console.WriteLine("2 - Show books");
        Console.WriteLine("3 - Remove a book");
        Console.WriteLine("4 - Search book");
        Console.WriteLine("5 - Exit");
    }

    public void DoTitle (string title)
    {
        int quantity = title.Length;
        string symbolTitle = title.PadLeft(quantity, '*');
        Console.WriteLine(symbolTitle);
        Console.WriteLine(title);
        Console.WriteLine(symbolTitle + "\n");
    }


}