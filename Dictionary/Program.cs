Dictionary<string, string> Cities = new Dictionary<string, string>
{
    {"India", "Mumbai"}, // You could add data like this either
    { "USA", "New York" }
};

Cities.Add("UK", "London"); // Easier way to do it
Cities.Add("IE", "Dublin");

string AccessingCity = Cities["UK"]; // Store value in a variable

Cities["India"] = "Nova Dehli"; // Update value

Cities.Remove("IE"); // As long as I remove the key it'll remove the value as well

foreach (KeyValuePair<string, string> dictionary in Cities) //this is the dictionary type (just to know)
{
    Console.WriteLine($"- Country: {dictionary.Key}; City: {dictionary.Value}");
}