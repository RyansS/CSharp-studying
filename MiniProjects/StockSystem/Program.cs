using System.Data.Common;
using System.Dynamic;

Menu(); // executes the Menu


Console.ReadKey();


static void Menu() //menu function
{
    Console.Clear();
        CreateTitle("Menu"); 

    Console.WriteLine("Option 1: Register a Product");  //all the options to do with the system
        Console.WriteLine("Option 2: See all Products"); // List all the products
            Console.WriteLine("Option 3: Search and select a Product"); // Search a product and select it
                Console.WriteLine("Option 4: Manage Products"); // Manage the product selected

    Console.Write("\nChoose a option: ");
        int optionChosen = int.Parse(Console.ReadLine());

    switch (optionChosen) // switch to manage the answers passed
    {
        case 1:
            Products storeProduct = registerProduct(); // the object returned from the register product function is stored on that variable
                Products.AllProducts.Add(storeProduct.Id, storeProduct); // add the product stored values in the dictionary
                        GetBackToMenu(); // go back to the menu
            break;
        case 2:
            SeeAllProducts(); // call the see all products function by pressing 2
            break;
        case 3:
            Products storeProductFound = SearchProducts(); //store the 
                GetBackToMenu();
            break;
        case 4:
            if (Products.containFoundObject.Count > 0)
            {
                ManageProduct(Products.containFoundObject[0]);
            }

            else if (Products.containFoundObject.Count <= 0)
            {
                Console.Clear();
                    Console.WriteLine("Please, select a product before managing a product!\n");
                        Console.ReadLine();
                            Menu();
            }
            break;
    }
}

static Products registerProduct()
{
    Console.Clear();
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
                Console.WriteLine("Product succeesfully registred!");
                    repeatCode = false;
        }

        else if (tempNameProduct == null || tempPriceProduct == null)
        {
            Console.WriteLine("Please fill all the camps!");
        }
    }

    return new Products(tempNameProduct, tempPriceProduct);
    
}



static void SeeAllProducts()
{
    Console.Clear();
        CreateTitle("All Products");

    Console.WriteLine("Products:");

    foreach (var ShowAllProductsName in Products.AllProducts)
    {
        Console.WriteLine($" {ShowAllProductsName.ToString()}");
    }

    GetBackToMenu();
}

static Products SearchProducts()
{

    bool repeatCode = true;
    int IdAnswer = 0;

    CreateTitle("Products Search");

    while (repeatCode)
    {
        Console.Write("\nType a Id: ");
        IdAnswer = int.Parse(Console.ReadLine());

        if (Products.AllProducts.ContainsKey(IdAnswer))
        {
            Console.WriteLine($"Product found!\n{Products.AllProducts[IdAnswer]}");
            repeatCode = false;
            Products.containFoundObject.Add(Products.AllProducts[IdAnswer]);
        }

        else if (Products.AllProducts.ContainsKey(IdAnswer) != true)
        {
            Console.WriteLine("We didn't find this product...");
            GetBackToMenu();
        }
    }

    return Products.AllProducts[IdAnswer];
}



static void ManageProduct(Products ProductSelected)
{
    Console.Clear();
    CreateTitle("Manage Product");

    bool repeatCode = true;

    while (repeatCode)
    {
        Console.WriteLine("Choose a option: ");
        Console.WriteLine("1-Delete Product");
        Console.WriteLine("2-Change Price");
        Console.WriteLine("3-Change Name");
        Console.WriteLine("0-Go back to menu\n");
        Console.WriteLine(ProductSelected.ToString());
        Console.WriteLine("");
        int answer = int.Parse(Console.ReadLine());

        switch (answer)
        {
            case 0:
                repeatCode = false;
                break;
            case 1:
                DeleteProduct(ProductSelected);
                break;
            case 2:
                ChangePrice(ProductSelected);
                break;
            case 3:
                ChangeName(ProductSelected);
                break;
        }
    }

    Products.containFoundObject.Remove(Products.containFoundObject[0]);
        Console.Clear();
            Menu();
}










static void DeleteProduct(Products ProductStoredToDelete)
{
    Console.Clear();
        Products.AllProducts.Remove(ProductStoredToDelete.Id);
            Console.WriteLine("\nProduct Succefully Removed!");
                Console.ReadLine();
                    Products.containFoundObject.Remove(Products.containFoundObject[0]);
                        Menu();
}

static void ChangePrice(Products ProductStoredToChangePrice)
{
    Console.Clear();
        Console.WriteLine(ProductStoredToChangePrice.ToString());

    Console.Write("\nChange the Price: ");
        double PriceChange = double.Parse(Console.ReadLine());

    if (PriceChange > 0 && PriceChange < 1000)
    {
        Products.AllProducts[ProductStoredToChangePrice.Id].Price = PriceChange;
            Console.WriteLine($"\nPrice Changed! New Price: {PriceChange}\n");
                Console.ReadLine();
    }

    else if (PriceChange < 0 || PriceChange > 1000)
    {
        Console.WriteLine("Please type a valid price!");
    }

}

static void ChangeName(Products ProductStoredToChangeName)
{
    Console.Clear();
    Console.WriteLine(ProductStoredToChangeName.ToString());

    Console.Write("\nChange the Name:");
        string NameChange = Console.ReadLine();

    if (NameChange != null)
    {
        Products.AllProducts[ProductStoredToChangeName.Id].ProductName = NameChange;
            Console.WriteLine($"Name Changed! New name: {NameChange}");
                Console.ReadLine();
    }

    else if (NameChange == "" || NameChange == null)
    {
        Console.WriteLine("Please type a valid Name!");
    }
    
}

static void GetBackToMenu()
{
    bool repeatCode = true;

    while (repeatCode)
    {

        Console.WriteLine("\n" + "Get back to menu by pressing 'M'");
            string answer = Console.ReadLine();
                answer.ToLower();

        if (answer == "m" || answer == "M")
        {
            Console.Clear();
                Menu();
                    repeatCode = false;
        }

        else
        {
            Console.Clear();
            Console.WriteLine("Please type correctly!");
        }
    
    }
    
}



static void CreateTitle(string title)
{
    int numbOfCharacters = title.Length;
        string symbols = string.Empty.PadLeft(numbOfCharacters, '-');

    Console.WriteLine(symbols);
        Console.WriteLine(title);
            Console.WriteLine(symbols);
}








class Products
{
        public static Dictionary<int, Products> AllProducts = new Dictionary<int, Products>();
            private string productName;
                private double price;
                    private int id;
                        private static int nextId = 1;
                            public static List<Products> containFoundObject = new List<Products>();
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
        return $"Product Name: {ProductName}, Price: {Price}$, Id: {Id}";
    }

}