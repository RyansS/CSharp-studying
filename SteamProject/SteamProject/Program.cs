
Console.WriteLine("Welcome to steam!");
List<string> credentials = new List<string>();

static void Register ()
{
    bool repeat = true;

    while (repeat)
    {

        Console.Write("How we should call you? ");
        string username = Console.ReadLine();

        Console.WriteLine("Now we need some crucial informations from you ");

        Console.Write("What's your email? ");
        string email = Console.ReadLine();

        Console.Write("\nNow create a strong password: ");
        string password = Console.ReadLine();

        if (username != null && email != null && password != null)
        {
            Console.WriteLine("\nThank you to joined the Steam universe!");
            repeat = false;
        }
        else
        {
            Console.WriteLine("\nPlease, keep sure that you've typed you're" +
                " credentials properly");
            repeat = true;
        }
    }
} 

static void Login ()
{
    Console.WriteLine("Welcome to Log-in!");
    Console.WriteLine("If you're not a member yet type: 'Register'," +
    "in case you're already a member, type: 'Login'");

    string option = Console.ReadLine();
    option.ToLower();

    if (option == "register")
    {
        Register();
    }
    else
    {
        Console.Write("Type here you're email: ");

        Console.WriteLine();
    }


}

class Account
{
    private string user;
    private string email;
    private string password;

    public Account (string user, string email, string password)
    {
        this.user = user;
        this.email = email;
        this.password = password;
    }

}
