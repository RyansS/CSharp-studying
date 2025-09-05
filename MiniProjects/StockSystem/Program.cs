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
            Products storeProductFound = SearchProducts(); //store the product found on the search product function
                GetBackToMenu();
            break;
        case 4:
            if (Products.containFoundObject.Count > 0) //Created a list to store the selected product always in the first position
            // and if it find a element inside of it, it's gonna call the function manage product
            // passing the object in the first position of this array through the function.
        
            {
                ManageProduct(Products.containFoundObject[0]);  //call the function manage product passing a object in the first position of an array
            }

            else if (Products.containFoundObject.Count <= 0) // if there aren't any elements in the array it's gonna give a alert and go to the menu.
            {
                Console.Clear();
                    Console.WriteLine("Please, select a product before managing a product!\n");
                        Console.ReadLine();
                            Menu();
            }
            break;
    }
}

static Products registerProduct() // return a object of the class Products
{
    Console.Clear();
        bool repeatCode = true; // variable to repeat a block of code until get at some point
            string tempNameProduct = ""; //temporary variable to return the object
                double tempPriceProduct = 0; //temporary variable to return the object

    CreateTitle("Product Register");

    while (repeatCode)  // it's gonna repeat until repeatCode is false.
    {

        Console.WriteLine("Name of your product: "); //registering name inside the variable
            tempNameProduct = Console.ReadLine();

        Console.WriteLine("Price of your product: "); //registering price inside the variable
            tempPriceProduct = double.Parse(Console.ReadLine());

        if (tempNameProduct != null && tempPriceProduct != null) // if the two temporary variables aren't null
        // the block of code is not gonna repeat anymore and it'll show a message
        {
            Console.Clear();
                Console.WriteLine("Product succeesfully registred!");
                    repeatCode = false;
        }

        else if (tempNameProduct == null || tempPriceProduct == null) //otherwise, it'll show a message and repeat the block
        {
            Console.Clear();
            Console.WriteLine("Please fill all the camps!");
        }
    }

    return new Products(tempNameProduct, tempPriceProduct); //when the repeatCode begins to value false, the code flow is come back to normal and execute the return
    // we're gonna return a new object of the class Products using as parameters our temporary variables.
    
}



static void SeeAllProducts() // return nothing
{
    Console.Clear();
        CreateTitle("All Products");

    Console.WriteLine("Products:");

    foreach (var ShowAllProductsName in Products.AllProducts) //show all products including: name, price and ID
    {
        Console.WriteLine($" {ShowAllProductsName.ToString()}"); //use the ToString overloaded method to show a string representation
        //of our object but including what we wanna show
    }

    GetBackToMenu(); // go back to menu
}

static Products SearchProducts() // it's gonna return a object of the class Products
{

    bool repeatCode = true; 
    int IdAnswer = 0; //local variable to store which id you typed

    CreateTitle("Products Search");

    while (repeatCode) // repeat the block of code
    {
        Console.Write("\nType a Id: "); //insert an id in the variable
        IdAnswer = int.Parse(Console.ReadLine()); 

        if (Products.AllProducts.ContainsKey(IdAnswer)) // in case the dictionary AllProducts has the key that we typed (IdAnswer)
        {
            Console.WriteLine($"Product found!\n{Products.AllProducts[IdAnswer]}"); //It'll show a message that we found the product
            // and show it
            repeatCode = false;
            Products.containFoundObject.Add(Products.AllProducts[IdAnswer]); // add this object to another array that always stays in 
            // the first position
            
        }

        else if (Products.AllProducts.ContainsKey(IdAnswer) != true) //the containskey return false or true, so 
        //if it's different from true it show a message that we didnt find this product and go back to the menu
        {
            Console.WriteLine("We didn't find this product...");
            GetBackToMenu();
        }
    }

    return Products.AllProducts[IdAnswer]; // return the object selected
}



static void ManageProduct(Products ProductSelected) //expects to receive a object of the class Products
{
    Console.Clear();
    CreateTitle("Manage Product");

    bool repeatCode = true;

    while (repeatCode) //repeat the block of code
    {
        Console.WriteLine("Choose a option: ");
            Console.WriteLine("1-Delete Product");
                Console.WriteLine("2-Change Price");
                    Console.WriteLine("3-Change Name");
                        Console.WriteLine("0-Go back to menu\n");
                            Console.WriteLine(ProductSelected.ToString());
        Console.WriteLine("");
            int answer = int.Parse(Console.ReadLine()); //depending on the answer it'll fit into the switch

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

    Products.containFoundObject.Remove(Products.containFoundObject[0]); //always remove the object selected after executing
    // the manageProduct
        Console.Clear();
            Menu();
}










static void DeleteProduct(Products ProductStoredToDelete) //delete the product received by the manage product function
{
    Console.Clear();
        Products.AllProducts.Remove(ProductStoredToDelete.Id); //remove from the AllProducts the object, but using the id of
        //  the product received
            Console.WriteLine("\nProduct Succefully Removed!");
                Console.ReadLine();
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