internal class Program
{
    private static void Main(string[] args)
    {


        Console.ReadKey();
    }
}

class UtilityMethod
{
    public static List<SignUp> Users = new();
    public static void CreateTitle(string title)
    {
        int numbCharacters = title.Length;
        string symbol = string.Empty.PadLeft(numbCharacters, '*');

        Console.WriteLine(symbol);
        Console.WriteLine(title);
        Console.WriteLine(symbol);

    }
}

class SignUp
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public SignUp (string name, string email, string password)
    {
        Name = name;
        Email = email;
        Password = password;
    }
    public static SignUp SignUpMethod() {

        UtilityMethod.CreateTitle("Welcome to sign up!");

            Console.WriteLine("Username: ");
            string usernick = Console.ReadLine();

            Console.WriteLine("Email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Password: ");
        string password = Console.ReadLine();

        return new SignUp(usernick, email, password);
    }
    
}