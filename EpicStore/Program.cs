using System.Text.Json;

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
    
    public string Name { get; private set; }
    private string InternalName {  get; set; }
    public decimal Price { get; private set; }
    private int GameId {  get; set; }
    public double Rating { get; private set; }
}