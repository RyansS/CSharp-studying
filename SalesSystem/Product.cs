using System.Text.Json.Serialization;

class Product
{
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("normalPrice")]
    public double Price { get; set; }

    [JsonPropertyName("gameID")]
    public int GameId { get; set; }

    [JsonPropertyName("internalName")]
    public string InternalName { get; set; }
}