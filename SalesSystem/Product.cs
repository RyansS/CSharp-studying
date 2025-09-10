using System.Text.Json.Serialization;
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
        Program.CreateTitle("All Products");

        foreach (var product in listFromAPI) {
            Console.WriteLine($"Title: {product.Title}, Price: {product.Price}, ID: {product.GameId}");
        }
    }
}