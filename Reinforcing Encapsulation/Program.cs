internal class Program
{
    private static void Main(string[] args)
    {
        Product Sponge = new Product("Sponge", 3.2m, 0);
        Product Orange = new Product("Orange", 0.3m, 0);
        Product Banana = new Product("Banana", 0.4m, 0);
        Product.AllItems.Add(Sponge);
        Product.AllItems.Add(Orange);
        Product.AllItems.Add(Banana);
        
    }
}

class Product
{
    private string name;
    private decimal price;
    private int quantity;
    public static List<Product> AllItems = new List<Product>();

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
                ShowProductDescription();
                break;

            case 2:
                ChangePrice(AllItems);
                break;

            case 3:
                ManageStock(AllItems);
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

    public void ChangePrice(List<Product> items)
    {
        Console.Write("Change the price: ");
        decimal NewPrice = decimal.Parse(Console.ReadLine());

        items[0].Price = NewPrice;

        Console.WriteLine("The price has changed!");
        Console.ReadLine();
    }

    public void ManageStock(List<Product> items)
    {
        Console.Write("Write the quantity of the item: ");
        int NewQuantity = int.Parse(Console.ReadLine());

        items[0].Quantity = NewQuantity;

        Console.WriteLine("The stock was succesfully changed!");
        Console.ReadLine();
    }

}