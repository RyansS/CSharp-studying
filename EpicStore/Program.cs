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

    public void CreateTitle(string title)
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
    private string name;

    [JsonPropertyName("internalName")]
    private string internalname;

    [JsonPropertyName("normalPrice")]
    private decimal price;

    [JsonPropertyName("gameID")]
    private int gameid;

    [JsonPropertyName("dealRating")]
    private double rating;

    public string Name { get; private set; }
    private string InternalName { get; set; }
    public decimal Price { get; private set; }
    private int Gameid { get; set; }
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
    private string nickname;
    private decimal balance;
    private string email;
    private string password;
    private int userid = 0;

    public string Nickname { get; private set; }

    public decimal Balance { get; private set; }

    private string Email { get; set; }

    private string Password { get; set; }

    private int Userid { get; set; }

    public User (string nickname, decimal balance, string email, string password)
    {
        Nickname = nickname;
        Balance = balance;
        Email = email;
        Password = password;
        userid += 1;
    }
}