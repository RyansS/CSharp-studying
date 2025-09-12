
using System.Text.Json;
using System.Text.Json.Serialization;
internal class Program
{
    private static async Task Main(string[] args)
    {
        using (HttpClient client = new HttpClient())
        {
            string RequestAnswer = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
            List<Product> ProductsInfo = JsonSerializer.Deserialize<List<Product>>(RequestAnswer)!;

            string receiveUsers = await client.GetStringAsync("https://dummyjson.com/users");
            List<Client> ClientsInfo = JsonSerializer.Deserialize<List<Client>>(receiveUsers)!;

            Menu(ProductsInfo, ClientsInfo);
        }

        Console.ReadKey();

    }

    class UtilityMethods
    {
        public static void CreateTitle(string title)
        {
            int numbOfLetters = title.Length;
            string symbol = string.Empty.PadLeft(numbOfLetters, '-');
            Console.Clear();
            Console.WriteLine(symbol);
            Console.WriteLine(title);
            Console.WriteLine(symbol);
        }
    }

    class Client
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("username")]
        public string Name { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }



        public static void SeeAndSearchClients(List<Client> ClientApi)
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
                                ClientApi.Remove();

                                break;
                            case 2:
                            
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
        public double Price { get; set; }

        [JsonPropertyName("gameID")]
        public int GameId { get; set; }

        [JsonPropertyName("internalName")]
        public string InternalName { get; set; }

        [JsonPropertyName("steamRatingCount")]
        public int? NumberOfSells { get; set; }


        public static void SeeAllProducts(List<Product> listFromAPI)
        {
            UtilityMethods.CreateTitle("All Products");

            foreach (var product in listFromAPI)
            {
                Console.WriteLine($"Title: {product.Title}, Price: {product.Price}, ID: {product.GameId}");
            }
        }

        public static void SearchProducts(List<Product> ProductsInfo)
        {
            UtilityMethods.CreateTitle("Search a Product");

            Console.WriteLine("1- Search");
            int optionChosen = int.Parse(Console.ReadLine());

            if (optionChosen == 1)
            {

                Console.WriteLine("-1 Search games by id: ");
                Console.WriteLine("-2 Search games by title: ");
                int idOrTitleTyped = int.Parse(Console.ReadLine());

                if (idOrTitleTyped == 1)
                {
                    try
                    {
                        Console.Clear();
                        Console.Write("Enter an ID: ");
                        int idTyped = int.Parse(Console.ReadLine());

                        var findGameById = ProductsInfo.Where(gameExpect => gameExpect.GameId == idTyped).FirstOrDefault();

                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine($"There was a problem...\n{ex}");
                    }
                }

                else if (idOrTitleTyped == 2) {
                    try
                    {
                        Console.Clear();
                        Console.Write("Search a Title: ");
                        string titleTyped = Console.ReadLine();
                        string formatedInput = titleTyped.Replace(" ", "").ToUpper();

                        var findGameByTitle = ProductsInfo.Where(gameExpect => gameExpect.InternalName == titleTyped).FirstOrDefault();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"There was a problem...\n{ex}");
                    }
                }

            }
        } 
    }




    static void Menu(List<Product> ProductsInfo, List<Client> ClientsInfo)
    {
        UtilityMethods.CreateTitle("Sales System");
        Console.WriteLine("1- See All Products");
        Console.WriteLine("2- Search Products");
        Console.WriteLine("3- See and search clients");
        Console.WriteLine("4- Calculate biling");

        int optionChosen = int.Parse(Console.ReadLine());

        switch (optionChosen)
        {
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

                break;
        }
    }
}

    
