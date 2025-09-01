
using System.Data.Common;
using System.Dynamic;

Dictionary<int, Products> AllProducts = new Dictionary<int, Products>();
HashSet<string> NameOfAllProducts = new HashSet<string>();
NameOfAllProducts.Add("aaa");
NameOfAllProducts.Add("bbb");
NameOfAllProducts.Add("ccc");

SeeAllProducts();

void Menu ()
{
    CreateTitle("Menu");

    Console.Write("\nChoose a option: ");
        int optionChosen = int.Parse(Console.ReadLine());

    Console.WriteLine("Option 1: Register a Product");
    Console.WriteLine("Option 2: See all Products");
    Console.WriteLine("Option 3: Search for a Product");

    switch (optionChosen)
    {
        case 1:
            Products storeProduct = registerProduct();
            AllProducts.Add(storeProduct.Id, storeProduct);
            NameOfAllProducts.Add(storeProduct.ProductName);
            break;
        case 2:

            break;
        case 3:

            break;
            
        
    }
}

void SeeAllProducts ()
{
    CreateTitle("All Products");

    foreach (string ShowAllProductsName in NameOfAllProducts) {
        Console.WriteLine(ShowAllProductsName);
    }
}

static Products registerProduct()
{
    bool repeatCode = true;
    string tempNameProduct = "";
    double tempPriceProduct = 0;

    CreateTitle("Product Register");

    while (repeatCode)
    {

        Console.WriteLine("Name of your product: ");
        tempNameProduct = Console.ReadLine();

        Console.WriteLine("Price of your product: ");
        tempPriceProduct = double.Parse(Console.ReadLine());

        if (tempNameProduct != null && tempPriceProduct != null)
        {
            Console.Clear();
            Console.WriteLine("Product succeedfuly registred!");
            repeatCode = false;
        }

        else if (tempNameProduct == null || tempPriceProduct == null)
        {
            Console.WriteLine("Please fill all the camps!");
        }
    }

    return new Products(tempNameProduct, tempPriceProduct);

}

static void CreateTitle (string title)
{
    int numbOfCharacters = title.Length;

    Console.WriteLine(title.PadLeft(numbOfCharacters, '-'));
    Console.WriteLine(title);
    Console.WriteLine(title.PadLeft(numbOfCharacters, '-'));
}

class Products
{
    private string productName;
    private double price;
    private int id;
    private int nextId = 0;

    public string ProductName { get { return productName; } set { productName = value; } }
    public double Price { get { return price; } set { price = value; } }
    public int Id { get { return id; } set { id = value; } }

    public Products(string product, double price)
    {
        ProductName = product;
        Price = price;
        Id = nextId;
        nextId++;
    }

}