using System.Text.Json;
using System.Text.Json.Serialization;

internal class Program
{
    private static async Task Main(string[] args)
    {
        using (HttpClient client = new HttpClient())
        {
            string apiRequest = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
            var apiData = JsonSerializer.Deserialize <List<GamesInfo>>(apiRequest);
        }
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
    private string InternalName {  get; set; }
    public decimal Price { get; private set; }
    private int Gameid {  get; set; }
    public double Rating { get; private set; }

    public GamesInfo (string name, string internalName, decimal price, int gameid, double rating)
    {
        Name = name;
        InternalName = internalname;
        Price = price;
        Gameid = gameid;
        Rating = rating;
    }
}