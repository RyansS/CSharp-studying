internal class Program
{
    private static void Main(string[] args)
    {
        bool agai = true;


        Console.WriteLine("what's the name of you're dogs?");
        string dogs = Console.ReadLine();

        namedogs(dogs); //here we invoke the method
        namedogs(dogs);
        namedogs(dogs);

        Console.ReadKey();
    }
    static void namedogs(string dogs) //here we create the method
        // here's the methods, they can be used to use less code
    {
        Console.WriteLine("Here's you're dogs: " + dogs);
    }
}