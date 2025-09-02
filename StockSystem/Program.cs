using System.Data.Common;
using System.Dynamic;

SeeAllProducts();

static void Menu ()
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
                Products.AllProducts.Add(storeProduct.Id, storeProduct);
                    Products.NameOfAllProducts.Add(storeProduct.ProductName);
            break;
        case 2:
            SeeAllProducts();
            break;
        case 3:
            Products storeProductFound = SearchProducts();
            break;
    }
}

static Products SearchProducts ()
{

    bool repeatCode = true;
    int IdAnswer = 0;

    CreateTitle("Products Search");

    while (repeatCode)
    {
        Console.WriteLine("\n Type a Id: ");
        IdAnswer = int.Parse(Console.ReadLine());

        if (Products.AllProducts.ContainsKey(IdAnswer))
        {
            Console.WriteLine($"Product found!\n {Products.AllProducts[IdAnswer]}");
            repeatCode = false;

            GetBackToMenu();
        }

        else
        {
            Console.WriteLine("We didn't find this product...");
        }
    }

    return Products.AllProducts[IdAnswer];

}

static void ManageProduct ()
{
    CreateTitle("Manage Product");

    bool repeatCode = true;

    while (repeatCode) {

    Console.WriteLine("Choose a option: ");
        Console.WriteLine("1-Delete Product");
        Console.WriteLine("2-Change Price");
        Console.WriteLine("3-Change Name");

    int answer = int.Parse(Console.ReadLine());

        switch (answer)
        {
            case 1:
            
                break;
            case 2:
            
                break;
            case 3:
            
                break;
        
        }
    }
    
}

static void GetBackToMenu()
{
    Console.WriteLine("Get back to menu by pressing 'M'");
    string answer = Console.ReadLine();
    answer.ToLower();

    if (answer == "m")
    {
        Console.Clear();
        Menu();
    }
}

static void SeeAllProducts()
{
    CreateTitle("All Products");

    foreach (string ShowAllProductsName in Products.NameOfAllProducts)
    {
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
    char symbol = '-';
    int numbOfCharacters = title.Length;

    Console.WriteLine(title.PadLeft(numbOfCharacters, symbol));
    Console.WriteLine(title);
    Console.WriteLine(title.PadLeft(numbOfCharacters, symbol));
}

class Products
{
    public static HashSet<string> NameOfAllProducts = new HashSet<string>();
    public static Dictionary<int, Products> AllProducts = new Dictionary<int, Products>();
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

    public override string ToString()
    {
        return $"Product name {ProductName}, Id: {Id}";
    }

}