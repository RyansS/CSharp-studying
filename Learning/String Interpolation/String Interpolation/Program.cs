internal class Program
{
    private static void Main(string[] args)
    {
        string name;
        int age;
        string lastname;

        Console.WriteLine("Hi, let's register you!");

        Console.WriteLine("What's you're name? ");
        name = Console.ReadLine();

        Console.WriteLine("What's you're last name? ");
        lastname = Console.ReadLine();

        Console.WriteLine("What's you're age? ");
        age = int.Parse(Console.ReadLine());

        Console.WriteLine($"Hello {name} {lastname}, you're {age} years old! ");
        //Basically the string interpolation allow u to write easier more variables in a string literal


        Console.ReadKey();
    }
}