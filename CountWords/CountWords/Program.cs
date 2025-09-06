internal class Program
{
    private static void Main(string[] args)
    {
        
    }
    static void CountWord ()
    {
        Console.Write("Write a phrase: ");
        string phrase = Console.ReadLine();
        string[] words = phrase.Split(' ');

        Dictionary<string,int> allwords = new Dictionary<string, int>();

        foreach (string word in words) {
            
    }

    static void Title(string title)
    {
        int CaracTitle = title.Length;
        string Asterict = title.PadLeft(CaracTitle, '*');
        Console.WriteLine(Asterict);
        Console.WriteLine(title);
        Console.WriteLine(Asterict);
    }
}