using System.Text.Json;

Console.WriteLine("ReadFiles and WriteFiles program");
Files.Menu ();
class Files
{
    public static List<Files> AllFiles = new List<Files>();
    public static void Menu ()
{
    Console.WriteLine("1- Read");
    Console.WriteLine("2- Write");
    Console.WriteLine("3- Exit");

    Console.Write("Select an option: ");
    bool NumberisValid = int.TryParse(Console.ReadLine(), out int InputNumber);

    Console.WriteLine(InputNumber);

    if (NumberisValid == true)
    {
        string path = @"C:\Users\monte\Desktop\tghd";

        if (File.Exists(path))
        {
            string jsonFile = File.ReadAllText(path);

            Files jsonLoaded = JsonSerializer.Deserialize<Files>(jsonFile);
            AllFiles.Add(jsonLoaded);

            foreach (var ShowItems in AllFiles)
            {
                Console.WriteLine($"Items inside the file: {ShowItems}");
            }
        }
    }

    else
    {
        Console.WriteLine("Your number isn't valid!");
    }
}
}
