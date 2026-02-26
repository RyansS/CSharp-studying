using Constructors;

internal class Program
{
    private static void Main(string[] args)
    {
        Games hollowknight = new Games("Hollow Knight", 50);
        Games sekiro = new Games("Sekiro Shadows Die Twice", 150);

        hollowknight.buy();
        sekiro.buy();

        Console.ReadKey();
    }
}