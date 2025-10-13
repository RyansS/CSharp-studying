internal class Program
{
    private static void Main(string[] args)
    {
        

        
    }
}

class Product
{
    private string name;
    private decimal price;
    private int quantity;

    public string Name { get; }
    public decimal Price { get; private set; }
    public int Quantity { get; private set; }

    public void Menu()
    {
        bool repeatCode = true;

        CreateTitle("Menu");
        Console.WriteLine("1- Show Product");
        Console.WriteLine("2- Change Price");
        Console.WriteLine("3- Manage Stock");
        Console.WriteLine("0- Exit");

        int answer = int.Parse(Console.ReadLine());

        switch (answer)
        {
            case 0:
                repeatCode = false;
                break;

            case 1:
                
                break;

            case 2:

                break;

            case 3:

                break;
        }
    }

    public void CreateTitle(string title)
    {
        int numbOfCharacters = title.Length;
        string symbol = string.Empty.PadLeft(numbOfCharacters, '-');

        Console.WriteLine(symbol);
        Console.WriteLine(title);
        Console.WriteLine(symbol);
    }

    public Product(string name, decimal price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public void ShowProductDescription()
    {
        Console.WriteLine($"Name: {Name}, Price: {Price}, Stock: {Quantity}");
    }

    public void ChangePrice(Product item)
    {
        Console.Write("Change the price: ");
        decimal NewPrice = decimal.Parse(Console.ReadLine());

        item.Price = NewPrice;

        Console.WriteLine("The price has changed!");
        Console.ReadLine();
    }

    public void ManageStock(Product item)
    {
        Console.Write("Write the quantity of the item: ");
        int NewQuantity = int.Parse(Console.ReadLine());

        item.Quantity = NewQuantity;

        Console.WriteLine("The stock was succesfully changed!");
        Console.ReadLine();
    }

}