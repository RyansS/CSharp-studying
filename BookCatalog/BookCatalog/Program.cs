
using Library;
using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        var catalog1 = new BookCatalog();
        Menu("Welcome to the library!");
        
    }
    

    public void DoTitle (string title)
    {
        int quantity = title.Length;
        string symbolTitle = title.PadLeft(quantity, '*');
        Console.WriteLine(symbolTitle);
        Console.WriteLine(title);
        Console.WriteLine(symbolTitle + "\n");
    }

    public static void Menu(string v)
    {
        Console.Clear();
        Console.WriteLine("\n");
        Console.WriteLine("1 - Show books");
        Console.WriteLine("2 - Add a book");
        Console.WriteLine("3 - Remove a book");
        Console.WriteLine("4 - Search book");
        Console.WriteLine("5 - Exit");

        Console.Write("\n");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                
                break;
            case "2": break;
            case "3": break;
            case "4": break;
            case "5": break;
        }

    }


}