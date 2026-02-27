using System.Text.Json;
using System.Text.Json.Serialization;
using HttpClient client = new HttpClient();
{
    string request = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

    var AllSongs = JsonSerializer.Deserialize<List<Song>>(request);

    // Filter.ShowDetails(AllSongs);
    Filter.FilterGenres(AllSongs);
}

class Song
{
    [JsonPropertyName ("artist")]
    public string Name {get; set;}

    [JsonPropertyName ("song")]
    public string SongName {get; set;}

    [JsonPropertyName ("genre")]
    public string Genre {get; set;}
}

class Filter
{
    public static void ShowDetails (List<Song> Allsongs)
    {
        foreach (var showall in Allsongs)
        {
            Console.WriteLine($"- Artist: {showall.Name}");
            Console.WriteLine($"- Song: {showall.SongName}");
            Console.WriteLine($"- Genre: {showall.Genre}");
        }
    }

    public static void FilterGenres (List<Song> Allsongs)
    {
        var FiltredGenres = Allsongs.Select(expects => expects.Genre).Distinct().ToList();

        Console.WriteLine($"{FiltredGenres}");
    }
}
 
