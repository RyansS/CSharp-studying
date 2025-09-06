internal class Program
{
    private static void Main(string[] args)
    {
        int age;
        string message;

        Console.WriteLine("How old are you? ");
        age = int.Parse(Console.ReadLine());

        message = (age > 18) ? "You can drink beer" : "you're a minor, you can't drink"; 
        //this works the same as a if statemant but it's used just 1 line, but it must be assigned in a variable


        Console.WriteLine(message);

        Console.ReadKey();
    }
}