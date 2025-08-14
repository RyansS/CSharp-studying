
List<Account> AccsInfo = new List<Account>();

Console.WriteLine("Welcome to steam!");

Account Register()
{
        Console.Write("How we should call you? ");
        string TempUsername = Console.ReadLine();

        Console.WriteLine("Now we need some crucial informations from you ");

        Console.Write("What's your email? ");
        string TempEmail = Console.ReadLine();

        Console.Write("\nNow create a strong password: ");
        string TempPassword = Console.ReadLine();

        if (TempUsername != null && TempEmail != null && TempPassword != null)
        {
            Console.WriteLine("\nThank you to joined the Steam universe!");
            Login();
        }
        else
        {
            Console.WriteLine("\nPlease, keep sure that you've typed you're" +
                " credentials properly");
            Register();
        }
  
    return new Account(TempUsername, TempEmail, TempPassword);
} 

void Login ()
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
        string tempEmail = Console.ReadLine();

        Console.Write("\nEnter password: ");
        string tempPassword = Console.ReadLine();

        var find = AccsInfo.Where(x => x.Email == tempEmail && x.Password == tempPassword);

    }

    void CreateTitle(string title)
    {
        int numberOfLetters = title.Length;
        string symbols = string.Empty.PadLeft(numberOfLetters, '-');
    }

}

class Account
{
    private string user;
    private string email;
    private string password;

    public string User { get { return user; } set { user = value; } }
    public string Email { get { return email; } set { email = value; } }
    public string Password { get { return password; } set { password = value; } }

    public Account (string user, string email, string password)
    {
        this.user = user;
        this.email = email;
        this.password = password;
    }

}
