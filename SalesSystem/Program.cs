
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

            Client testclient = new Client("Henrique", 19, "davibrito@gmail.com", "h19brito");

            Menu(ProductsInfo);
        }

        Console.ReadKey();

    }
    
    class UtilityMethods
        {
            public static void CreateTitle(string title)
            {
                int numbOfLetters = title.Length;
                string symbol = string.Empty.PadLeft(numbOfLetters, '-');

                Console.WriteLine(symbol);
                Console.WriteLine(title);
                Console.WriteLine(symbol);
            }
        }

class Client
    {
        private string name;
        private int age;
        private string email;
        private string password;

        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Password { get { return password; } set { password = value; } }

        public Client(string name, int age, string email, string password)
        {
            Name = name;
            Age = age;
            Email = email;
            Password = password;
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


        class FilterProducts
        {
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
    }



    static void Menu(List<Product> ProductsInfo)
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
                FilterProducts.SearchProducts(ProductsInfo);
                break;
            case 3:

                break;
            case 4:

                break;
        }
    }
}

    
