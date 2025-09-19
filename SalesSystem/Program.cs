
using System.Text.Json;
using System.Text.Json.Serialization;
internal class Program
{
    private static async Task Main(string[] args)
    {
        List<Product> ProductsInfo = await UtilityMethods.GetInfoFromProductApi(); // receive the deserialized api using the function GetInfoFromApi from the class UtilityMethods
        List<Client> ClientsInfo = await UtilityMethods.UserRequest.GetInfoFromUserApi(); //receive the deserialized api using the function GetInfoFromApi from the class UtilityMethods

        while (UtilityMethods.repeatMenu) {
             UtilityMethods.Menu(ProductsInfo, ClientsInfo); //repeat the menu until it's false and passes the both lists in the menu
        }
    }

    class UtilityMethods
    {
        public static bool repeatMenu = true; // variable created to repeat

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

            if (optionChosen == 1)
            {
                Console.WriteLine();
                foreach (var inEachClient in ClientApi)
                {
                    Console.WriteLine($"Username: {inEachClient.Name}, Email: {inEachClient.Email}," +
                    $" Password: {inEachClient.Password}, Id: {inEachClient.Id}");
                }
            }

            else if (optionChosen == 2)
            {
                try
                {
                    Console.WriteLine("Type a client id to manage it: ");
                    int idAnswer = int.Parse(Console.ReadLine());

                    var findClientById = ClientApi.Where(ClientExpect => ClientExpect.Id == idAnswer);

                    if (findClientById != null)
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
                                ClientApi.Remove(ClientApi[idAnswer - 1]);
                                Console.WriteLine("Client succesfully removed!");
                                Console.ReadLine();


                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("1- Edit Name");
                                Console.WriteLine("2- Edit Password");
                                Console.WriteLine("3- Edit Id");
                                int answerEdit = int.Parse(Console.ReadLine());

                                switch (answerEdit)
                                {
                                    case 1:

                                        bool repeatCode = true;

                                        while (repeatCode)
                                        {
                                            Console.Clear();
                                            Console.WriteLine($"{findClientById.ToString()}");
                                            Console.Write("\nChange the name: ");
                                            string nameChanged = Console.ReadLine()!;

                                            if (nameChanged != "")
                                            {
                                                ClientApi[idAnswer - 1].Name = nameChanged!;
                                                repeatCode = false;
                                            }
                                            else if (nameChanged == "")
                                            {
                                                Console.WriteLine("Please, keep sure that you have fill the camp!");
                                            }
                                        }

                                        break;
                                    case 2:

                                        bool repeatCode2 = true;

                                        while (repeatCode2)
                                        {
                                            Console.Clear();
                                            Console.WriteLine($"{findClientById.ToString()}");
                                            Console.Write("\nChange the name: ");
                                            string passwordChanged = Console.ReadLine()!;

                                            if (passwordChanged != "")
                                            {
                                                ClientApi[idAnswer - 1].Password = passwordChanged!;
                                                repeatCode = false;
                                            }
                                            else if (passwordChanged == "")
                                            {
                                                Console.WriteLine("Please, keep sure that you have fill the camp!");
                                            }
                                        }

                                        break;
                                    case 3:

                                        bool repeatCode3 = true;
                                        while (repeatCode3)
                                        {
                                            Console.Clear();

                                            foreach (var inEachClient in ClientApi)
                                            {
                                                Console.WriteLine($"{findClientById.ToString()}");
                                                Console.Write("\nChange the name: ");
                                                int idChanged = int.Parse(Console.ReadLine())!;

                                                if (idChanged != null && idChanged != inEachClient.Id)
                                                {
                                                    ClientApi[idAnswer - 1].Id = idChanged!;
                                                    repeatCode = false;
                                                }

                                                else if (idChanged == null)
                                                {
                                                    Console.WriteLine("Please, keep sure that you have fill the camp!");
                                                }
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



        public override string ToString()
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
            UtilityMethods.CreateTitle("All Products");
            Console.WriteLine("");

            foreach (var product in listFromAPI)
            {
                Console.WriteLine($"Title: {product.Title}, Price: {product.Price}, ID: {product.GameId}");
            }
            Console.ReadLine();
        }

        public static void SearchProducts(List<Product> ProductsInfo)
        {
            UtilityMethods.CreateTitle("Search a Product");

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

                        var findGameById = ProductsInfo.Where(gameExpect => gameExpect.GameId == idTyped).FirstOrDefault();

                        Console.WriteLine(findGameById.ToString());

                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine($"There was a problem...\n{ex}");
                    }
                }

                else if (idOrTitleTyped == 2)
                {

                    try
                    {
                        Console.Clear();
                        Console.Write("Search a Title: ");
                        string titleTyped = Console.ReadLine();
                        string formatedInput = titleTyped.Replace(" ", "").ToUpper();

                        var findGameByTitle = ProductsInfo.Where(gameExpect => gameExpect.InternalName == titleTyped).FirstOrDefault();

                        Console.WriteLine(findGameByTitle.ToString());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"There was a problem...\n{ex}");
                    }

                }

            
        }

        public static void CalculateBiling(List<Product> ProductInfo, List<Client> ClientInfo)
        {

            bool repeatCode = true;

            while (repeatCode)
            {

                UtilityMethods.CreateTitle("Biling Calculator");

                Console.WriteLine("1- Show User Boughts by ID");
                Console.WriteLine("2- Show Total Biling");
                Console.WriteLine("3- Show Specific Game Boughts");

                int optionChosen = int.Parse(Console.ReadLine());

                if (optionChosen == 1 || optionChosen == 2 || optionChosen == 3)
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
            int random = randomNumber.Next(1, 100000);

            UtilityMethods.CreateTitle("User Boughts");

            Console.Write("Type a id: ");
            int idAnswer = int.Parse(Console.ReadLine());

            var findClientById = ClientInfo.Where(ClientExpect => ClientExpect.Id == idAnswer).FirstOrDefault();

            string nameOfTheClient = ClientInfo[idAnswer - 1].Name; // pay attention because I think it can be null

            Console.WriteLine($"Customer: {nameOfTheClient}, Boughts: {ProductInfo[random].NumberOfSells}");
            Console.ReadLine();
        }

        public static void TotalBiling(List<Product> ProductInfo)
        {
            UtilityMethods.CreateTitle("Total Biling");

            foreach (var inEachProduct in ProductInfo)
            {
                
                decimal totalbiling = decimal.Parse(inEachProduct.Price) * int.Parse(inEachProduct.NumberOfSells);
                Console.WriteLine($"\nNumber of total sells: {inEachProduct.NumberOfSells}, Total Biling: {totalbiling}");
            }
        }

        public static void SpecificGameBoughts(List<Product> ProductInfo)
        {
            UtilityMethods.CreateTitle("Game Boughts");

            Console.WriteLine("Search By Typing a Title: ");
            string titleWritten = Console.ReadLine()!;

            if (titleWritten != "")
            {
                titleWritten = titleWritten.Replace(" ", "").ToUpper();
            }

            else if (titleWritten == "")
            {
                Console.WriteLine("We didn't find your game...");
            }


            var findIdUsingTheTitle = ProductInfo.Where(GameExpect => GameExpect.InternalName == titleWritten).FirstOrDefault();

            Console.WriteLine($"{findIdUsingTheTitle.Title} Boughts: {findIdUsingTheTitle.NumberOfSells}");
 
        }
    }  
}