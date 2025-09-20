
using System.Text.Json;
using System.Text.Json.Serialization;
internal class Program
{
    private static async Task Main(string[] args)
    {
        List<Product> ProductsInfo = await UtilityMethods.GetInfoFromProductApi(); // receive the deserialized api using the function GetInfoFromApi from the class UtilityMethods
        List<Client> ClientsInfo = await UtilityMethods.UserRequest.GetInfoFromUserApi(); //receive the deserialized api using the function GetInfoFromApi from the class UtilityMethods


        while (UtilityMethods.repeatMenu = true)
        {
            UtilityMethods.Menu(ProductsInfo, ClientsInfo); //repeat the menu until it's false and passes the both lists in the menu
        }
    }

    class UtilityMethods
    {
        public static bool repeatMenu = true; // variable created to repeat the menu
        public static bool repeatCode = true;

        public static async Task<List<Product>> GetInfoFromProductApi() //functions to deserialize the api
        {
            using (HttpClient client = new HttpClient()) //creates a new object from the class HttpClient
            {
                string receiveProducts = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals"); // receive the data in String, using the function by the object


                return JsonSerializer.Deserialize<List<Product>>(receiveProducts); //It will return the receiveProducts but Deserialized in a List of the class Product

            }

        }

        public class UserRequest //I had to create this class to solve a problem with my client API, It doesn't return a list of users, it returns a object that has a propertie called "users"
        {
            [JsonPropertyName("users")] //I created a propertie to store the return of my function
            public List<Client> Users { get; set; }
        
            public static async Task<List<Client>> GetInfoFromUserApi()
        {
            using (HttpClient client = new HttpClient())
            {
                string receiveUsers = await client.GetStringAsync("https://dummyjson.com/users"); //get the api
                var ApiResponse = JsonSerializer.Deserialize<UserRequest>(receiveUsers); // this variable will store the Deserialized data creating objects of the type UserRequest

                return ApiResponse.Users; //return the propertie

            }

        }
    }


        public static void CreateTitle(string title) // function to create better titles
        {
            int numbOfLetters = title.Length; // Catch the number of characters of the string
            string symbol = string.Empty.PadLeft(numbOfLetters, '-'); // variable to put the symbols based on the number of letters
            Console.Clear();
            Console.WriteLine(symbol);
            Console.WriteLine(title);
            Console.WriteLine(symbol);
        }

        public static void Menu(List<Product> ProductsInfo, List<Client> ClientsInfo) // Function Menu, the heart of the system
        {
            repeatCode = true;
            CreateTitle("Sales System"); //the Options for the user
            Console.WriteLine("1- See All Products");
            Console.WriteLine("2- Search Products");
            Console.WriteLine("3- See and search clients");
            Console.WriteLine("4- Calculate biling");
            Console.WriteLine("0- Exit");

            int optionChosen = int.Parse(Console.ReadLine());

            switch (optionChosen)
            {
                case 0:
                    repeatMenu = false;
                    break;
                case 1:
                    Product.SeeAllProducts(ProductsInfo);
                    break;
                case 2:
                    Product.SearchProducts(ProductsInfo);
                    break;
                case 3:
                    Client.SeeAndSearchClients(ClientsInfo);
                    break;
                case 4:
                    Product.CalculateBiling(ProductsInfo, ClientsInfo);
                    break;
            }
        }

    }

    class Client //class to manage the clients and its functions
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("username")]
        public string Name { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }



        public static void SeeAndSearchClients(List<Client> ClientApi) // expects to receive the list of ClientApi
        {
            UtilityMethods.CreateTitle("Manage Clients");

            Console.WriteLine("1- See all Clients");
            Console.WriteLine("2= Manage Clients");

            int optionChosen = int.Parse(Console.ReadLine());

            if (optionChosen == 1) // Show all the clients and their information using a foreach
            {
                Console.WriteLine();
                foreach (var inEachClient in ClientApi)
                {
                    Console.WriteLine($"Username: {inEachClient.Name}, Email: {inEachClient.Email}," +
                    $" Password: {inEachClient.Password}, Id: {inEachClient.Id}\n");
                }
                
                 Console.ReadLine();
            }

            else if (optionChosen == 2) // manage in general the clients having many options to do
            {
                try
                {
                    Console.WriteLine("Type a client id to manage it: ");
                    int idAnswer = int.Parse(Console.ReadLine());

                    var findClientById = ClientApi.Where(ClientExpect => ClientExpect.Id == idAnswer).FirstOrDefault(); //Search in the ClientApi a client that it's Id is the same of the Id typed by the user

                    if (findClientById != null) //if the findClientbyId returns something it will show the client information and sugest options to do with the client
                    {
                        Console.Clear();
                        Console.WriteLine(findClientById.ToString());

                        Console.WriteLine("\n1- Delete Client");
                        Console.WriteLine("2- Edit Client");
                        int option = int.Parse(Console.ReadLine());

                        switch (option)
                        {
                            case 1:
                                Console.Clear();
                                ClientApi.Remove(ClientApi[idAnswer - 1]); //this part of the code will use the .Remove function in the ClientApi. In the ClientApi position of the id answer -1
                                // the function will remove the object refered
                                Console.WriteLine("Client succesfully removed!");
                                Console.ReadLine();
                                break;

                            case 2:
                                Console.Clear();
                                Console.WriteLine("1- Edit Name");
                                Console.WriteLine("2- Edit Password");
                                int answerEdit = int.Parse(Console.ReadLine());

                                switch (answerEdit)
                                {
                                    case 1:

                                        while (UtilityMethods.repeatCode)
                                        {
                                            Console.Clear();
                                            Console.WriteLine($"{findClientById.ToString()}"); //based on the client found, show it
                                            Console.Write("\nChange the name: "); //type the name 
                                            string nameChanged = Console.ReadLine()!; //stores the answer

                                            if (nameChanged != "")
                                            {
                                                ClientApi[idAnswer - 1].Name = nameChanged!; //on the client api position of the answer of the id - 1 and name of it will be equals to the name changed
                                                UtilityMethods.repeatCode = false;
                                            }
                                            else if (nameChanged == "")
                                            {
                                                Console.WriteLine("Please, keep sure that you have fill the camp!");
                                            }
                                        }

                                        break;
                                    case 2:



                                        while (UtilityMethods.repeatCode) //SAME LOGIC ON ALL OF THE TWO METHODS
                                        {
                                            Console.Clear();
                                            Console.WriteLine($"{findClientById.ToString()}");
                                            Console.Write("\nChange the password: ");
                                            string passwordChanged = Console.ReadLine()!;

                                            if (passwordChanged != "")
                                            {
                                                ClientApi[idAnswer - 1].Password = passwordChanged!;
                                                UtilityMethods.repeatCode = false;
                                            }
                                            else if (passwordChanged == "")
                                            {
                                                Console.WriteLine("Please, keep sure that you have fill the camp!");
                                            }
                                        }

                                        break;
                                }
                                break;
                        }
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine($"There was a problem... {ex}");
                }

            }
        }



        public override string ToString() // overrided tostring method
        {
            return $"Username: {Name}, Email: {Email}," +
                    $" Password: {Password}, Id: {Id} ";
        }

    }

    class Product
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("normalPrice")]
        public string Price { get; set; }

        [JsonPropertyName("gameID")]
        public string GameId { get; set; }

        [JsonPropertyName("internalName")]
        public string InternalName { get; set; }

        [JsonPropertyName("steamRatingCount")]
        public string NumberOfSells { get; set; }


        public static void SeeAllProducts(List<Product> listFromAPI)
        {
            UtilityMethods.CreateTitle("All Products"); // just used a foreach to see all the products
            Console.WriteLine("");

            foreach (var product in listFromAPI)
            {
                Console.WriteLine($"Title: {product.Title}, Price: {product.Price}, ID: {product.GameId}");
            }
            Console.ReadLine();
        }

        public static void SearchProducts(List<Product> ProductsInfo)
        {
            UtilityMethods.CreateTitle("Search a Product"); //here you have the option to search the game by id or by title

                Console.WriteLine("- 1 Search games by id: ");
                Console.WriteLine("- 2 Search games by title: \n");
                int idOrTitleTyped = int.Parse(Console.ReadLine());

                if (idOrTitleTyped == 1)
                {
                try
                {
                    Console.Clear();
                    Console.Write("Enter an ID: ");
                    string idTyped = Console.ReadLine();

                    var findGameById = ProductsInfo.Where(gameExpect => gameExpect.GameId == idTyped).FirstOrDefault(); //it's the same logic from the clients

                    Console.WriteLine($"Name: {findGameById.Title}, Price: {findGameById.Price}");
                    Console.ReadLine();

                    }

                catch (Exception ex)
                {
                    Console.WriteLine($"There was a problem...\n{ex}");
                }
                }

                else if (idOrTitleTyped == 2)
                {

                    Console.Clear();
                    Console.Write("Search a Title: "); //here's a little bit different, we'll use the internal name of the game, so we dont have to write the name of the game 100% correctly
                    string titleTyped = Console.ReadLine(); //store the titletyped
                    string formatedInput = titleTyped.Replace(" ", "").ToUpper(); // create a variable to store the name of the title formated, without spaces and in uppercase (same as the internal)

                    var findGameByTitle = ProductsInfo.Where(gameExpect => gameExpect.InternalName == formatedInput).FirstOrDefault();

                    Console.WriteLine($"Name: {findGameByTitle.Title}, Price: {findGameByTitle.Price}");
                    Console.ReadLine();

                }

            
        }

        public static void CalculateBiling(List<Product> ProductInfo, List<Client> ClientInfo) // here we will just calculate the billing of our products
        {


            while (UtilityMethods.repeatCode)
            {

                UtilityMethods.CreateTitle("Biling Calculator");

                Console.WriteLine("1- Show User Boughts by ID");
                Console.WriteLine("2- Show Total Biling");
                Console.WriteLine("3- Show Specific Game Boughts");

                int optionChosen = int.Parse(Console.ReadLine());

                if (optionChosen == 1 || optionChosen == 2 || optionChosen == 3) //idk why but I didn't use a switch here
                {

                    switch (optionChosen)
                    {
                        case 1:
                            UserBoughtsById(ProductInfo, ClientInfo);
                            break;
                        case 2:
                            TotalBiling(ProductInfo);
                            break;
                        case 3:
                            SpecificGameBoughts(ProductInfo);
                            break;
                    }

                }

                else
                {
                    Console.WriteLine("Please be sure that you've typed the correct option!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        public static void UserBoughtsById(List<Product> ProductInfo, List<Client> ClientInfo)
        {
            Random randomNumber = new Random();
            int random = randomNumber.Next(1, 1000);

            UtilityMethods.CreateTitle("User Boughts");

            Console.Write("Type a user id: ");
            int idAnswer = int.Parse(Console.ReadLine());

            var findClientById = ClientInfo.Where(ClientExpect => ClientExpect.Id == idAnswer).FirstOrDefault(); //search for the id

            string nameOfTheClient = ClientInfo[idAnswer - 1].Name; // the name of the client will be searched in the postion of it

            Console.WriteLine($"Customer: {nameOfTheClient}, Boughts: {ProductInfo[random].NumberOfSells}"); // here it will just give us a imaginary number of boughts using the random number
            Console.ReadLine();
        }

        public static void TotalBiling(List<Product> ProductInfo)
        {
            UtilityMethods.CreateTitle("Total Biling");
            
            decimal totalBiling = 0;
            int totalSells = 0;

            foreach (var inEachProduct in ProductInfo)
            {
                totalBiling = totalBiling + decimal.Parse(inEachProduct.Price) * int.Parse(inEachProduct.NumberOfSells);
                totalSells = totalSells + int.Parse(inEachProduct.NumberOfSells);
            }

            Console.WriteLine($"\nNumber of total sells: {totalSells}, Total Biling: {totalBiling}\n"); // show it here

            Console.ReadLine();
        }

        public static void SpecificGameBoughts(List<Product> ProductInfo)
        {
            UtilityMethods.CreateTitle("Game Boughts"); // here it will do what the name of the function says

            Console.WriteLine("Search By Typing a Title: ");
            string titleWritten = Console.ReadLine()!;

            if (titleWritten != "")
            {
                titleWritten = titleWritten.Replace(" ", "").ToUpper(); //formate it
            }

            else if (titleWritten == "")
            {
                Console.WriteLine("We didn't find your game...");
            }


            var findIdUsingTheTitle = ProductInfo.Where(GameExpect => GameExpect.InternalName == titleWritten).FirstOrDefault();

            decimal total = int.Parse(findIdUsingTheTitle.NumberOfSells) * decimal.Parse(findIdUsingTheTitle.Price);

            Console.WriteLine($"{findIdUsingTheTitle.Title} Boughts: {findIdUsingTheTitle.NumberOfSells}, Total Biling of {findIdUsingTheTitle.Title}: ${total}: "); //just show the game boughts using the variable findIdUsingtheTitle
            Console.ReadLine();
 
        }
    }  
}