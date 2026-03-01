Console.WriteLine("Best cities to visit in the world!!");

class City
{
    public string Name {get; set;}
    public int Population {get; set;}
    public string Mayor {get; set;}

    public City (string name, int population, string mayor)
    {
        Name = name;
        Population = population;
        Mayor = mayor;
    }

    Dictionary<string, string> Cities = new Dictionary<string, string>
    {
        {"USA", "Washington"},
        {"IE", "Dublin"},
        {"BR", "Brasília"}
    };

    public static void Menu (Dictionary<string, string> Cities)
    {
        foreach(KeyValuePair<string, string> showCities in Cities)
        {
            Console.WriteLine("------------------");
            Console.WriteLine($"- {showCities.Key}, {showCities.Value}");
            Console.WriteLine("------------------");
        }
    }
}