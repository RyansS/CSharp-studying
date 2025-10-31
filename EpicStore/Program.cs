using System.Text.Json;
using System.Text.Json.Serialization;

internal class Program
{
    private static async Task Main(string[] args)
    {
        using (HttpClient client = new HttpClient())
        {
            string apiRequest = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
            var apiData = JsonSerializer.Deserialize<List<GamesInfo>>(apiRequest);
        }
    }
}

class UtilityMethods
{
    public static bool repeatCode;
    public static void CreateTitle(string title)
    {
        int numbCharacters = title.Length;
        string symbol = string.Empty.PadLeft(numbCharacters, '*');

        Console.WriteLine(symbol);
        Console.WriteLine(title);
        Console.WriteLine(symbol);

    }
}

class GamesInfo
{

    [JsonPropertyName("title")]
    public string Name { get; private set; }

    [JsonPropertyName("internalName")]
    private string InternalName { get; set; }

    [JsonPropertyName("normalPrice")]
    public decimal Price { get; private set; }

    [JsonPropertyName("gameID")]
    private int Gameid { get; set; }

    [JsonPropertyName("dealRating")]
    public double Rating { get; private set; }

    public GamesInfo(string name, string internalname, decimal price, int gameid, double rating)
    {
        Name = name;
        InternalName = internalname;
        Price = price;
        Gameid = gameid;
        Rating = rating;
    }
}

class User
{

    public string Nickname { get; private set; }

    public decimal Balance { get; private set; }

    private string Email { get; set; }

    private string Password { get; set; }

    private int Userid { get; set; }

    public User(string nickname, string email, string password)
    {
        Nickname = nickname;
        Email = email;
        Password = password;
        Userid += 1;
    }
    
    public static User SignUp ()
    {
        string usernick = "";
        string email = "";
        string password = "";


        while (UtilityMethods.repeatCode)
        {
            UtilityMethods.CreateTitle("Sign up");

            Console.WriteLine("Username: ");
            usernick = Console.ReadLine();

            Console.WriteLine("Email: ");
            email = Console.ReadLine();

            Console.WriteLine("Password: ");
            password = Console.ReadLine();

            if (usernick != "" && email != "" && password != "")
            {
                Console.WriteLine("You're signed up!");
            }
        }
        return new User(usernick,email,password);
    }
}