internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
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