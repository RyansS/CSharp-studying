using Students;

internal class Program
{
    private static void Main(string[] args)
    {
        student alex = new student("Alex",8,7.8);

        alex.study();
        alex.obgrade();

        Console.ReadKey();
    }
}