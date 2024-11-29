internal class Program
{
    private static void Main(string[] args)
    {
        string email;
        string password;
        string nick;
        string check;

        Console.WriteLine("Hi, let's register you!");

        Console.WriteLine("What's you're email?");
        email = Console.ReadLine();

        Console.WriteLine("Create a password:");
        password = Console.ReadLine();

        Console.WriteLine("Create you're nick");
        nick = Console.ReadLine();

        check = (nick.Length > 20) ? "You're nickname is too long!" : $"Welcome, {nick}";

        Console.WriteLine(check);

        Console.WriteLine($"You're credentials: {email}, {password} ");



        Console.ReadKey();
    }
}