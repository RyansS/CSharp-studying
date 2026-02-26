internal class Program
{
    private static void Main(string[] args)
    {
        PhysicalProduct newproduct = new("Box", 1, "A box of wood", 1, 95);

        Product.ShowProduct(newproduct);
    }
}

abstract class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }

    public Product(string name, decimal price, string description)
    {
        Name = name;
        Price = price;
        Description = description;
    }

    public static void ShowProduct(Product product)
    {
        Console.WriteLine(product.ToString());
    }

    public override string ToString()
    {
        return $"Name: {Name}, Price: {Price}";
    }

}

class PhysicalProduct : Product
{
    public int Weight { get; set; }
    public decimal Dimensions { get; set; }

    public PhysicalProduct(string name, decimal price, string description, int weight, decimal dimensions) : base(name, price, description)
    {
        Weight = weight;
        Dimensions = dimensions;
        Name = name;
        Price = price;
        Description = description;
    }
}

