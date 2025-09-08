
using (HttpClient client = new HttpClient())
{
    string answer = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
    Console.WriteLine(answer);
}



CreateTitle("Sales System");

Console.ReadKey();

static void CreateTitle(string title)
{
    int numbOfLetters = title.Length;
    string symbol = string.Empty.PadLeft(numbOfLetters, '-');

    Console.WriteLine(symbol);
    Console.WriteLine(title);
    Console.WriteLine(symbol);
}