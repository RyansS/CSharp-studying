internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine((int)daysof.Sunday); //here's how we represent it in a numerical way
        Console.WriteLine(daysof.Monday); //here's the normal way
        Console.ReadKey();
    }
}
enum daysof // Enum is a class/method that we use to create a group of named constants, that won't change never
{
    Monday = 1, // by default they follow the array counting rule, but there's a way to modificate these numbers
    Tuesday = 2, // just assign a number to them before the comma
    Wednesday = 3,
    Thursday = 4,
    Friday = 5,
    Saturday = 6,
    Sunday = 7
}