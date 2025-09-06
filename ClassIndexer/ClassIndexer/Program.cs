using ClassIndexer;

internal class Program
{
    private static void Main(string[] args)
    {
        var agenda = new TelefonicAgend();

        agenda["joai5"] = "1234";
        agenda["luiza"] = "2134";

        Console.WriteLine($"Luiza phone: {agenda["luiza"]}");
    }
}