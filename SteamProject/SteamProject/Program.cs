
using System.ComponentModel.Design;

List<Account> AccsInfo = new List<Account>();

Games.CreateTitle("Welcome to steam!");

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
        else if (TempUsername == null || TempEmail == null || TempPassword == null) 
        {
            Console.WriteLine("\nPlease, keep sure that you've typed you're" +
                " credentials properly");
            Register();
        }
  
    return new Account(TempUsername, TempEmail, TempPassword);
} 

void Login ()
{
    Games.CreateTitle("Welcome to Log-in!");
    Console.WriteLine("\nIf you're not a member yet type: 'Register'," +
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

class Games
{
    private static int nextId = 1;
    private string game;
    private double price;
    private int id;

    public string Game { get { return game; } set { game = value; } }
    public double Price { get { return price; } set { price = value; } }
    public int Id { get { return id; } set { id = value; } }

    public Games(string game, double price)
    {
        Game = game;
        Price = price;
        Id = nextId;
    }

    static void Menu()
    {

        Games.CreateTitle("Welcome to the Steam homepage!");
        Console.WriteLine("1 - See offers");
        Console.WriteLine("2 - Go to cart");
        Console.WriteLine("3 - Library");
        Console.WriteLine("4 - Profile");

        string option = Console.ReadLine();

        switch (option)
        {
            case "1":
                SeeOffers();
                break;
            case "2":

                break;
            case "3":

                break;
            case "4":

                break;
        }
    }

    public static void SeeOffers()
    {
        bool repeat = true;

        Games game1 = new Games("Counter Strike 2", 0);
        Games game2 = new Games("Dark Souls 3", 119.99);
        Games game3 = new Games("Cyberpunk 2077", 169.99);
        Games game4 = new Games("Red Dead Redemption 2", 199.99);
        Games game5 = new Games("Hollow Knight", 39.99);

        CreateTitle("Check out the offers of the week!");
        Console.WriteLine(game1);
        Console.WriteLine(game2);
        Console.WriteLine(game3);
        Console.WriteLine(game4);
        Console.WriteLine(game5);

        Console.WriteLine("\nIf you want any game type the name of it and it'll be added to the cart: ");
        string nameOfTheGame = Console.ReadLine();

        if (nameOfTheGame == "")
        {
            Console.WriteLine("Please type the name of a game!");
            Console.Clear();
            SeeOffers();
        }
        else if  (nameOfTheGame != "")
        {
            Console.WriteLine("Do you wanna add another game? (Y/N) ");
            string answerAddGame = Console.ReadLine();
            answerAddGame.ToLower();
            

            if (answerAddGame == "y")
            {
                SeeOffers();
            }
            else if (answerAddGame == "n")
            {
               
                while (repeat)
                {
                    Console.WriteLine("Get back to the menu by pressing 'M' ");
                    string ButtonPressed = Console.ReadLine();
                    ButtonPressed.ToUpper();

                    if (ButtonPressed == "M")
                    {
                        repeat = false;
                        Console.Clear();
                        Menu();
                    }
                    else if (ButtonPressed != "M")
                    {
                        Console.WriteLine("Please, type 'M' if you wanna get back to the menu");
                    }
                }
            }
        }

        Console.WriteLine("Get back to the menu by pressing 'M' ");
        string ButtonPressed2 = Console.ReadLine();
        ButtonPressed2.ToUpper();

        while (repeat)
        {
            Console.WriteLine("Get back to the menu by pressing 'M' ");
            string ButtonPressed = Console.ReadLine();
            ButtonPressed.ToUpper();

            if (ButtonPressed == "M")
            {
                repeat = false;
                Console.Clear();
                Menu();
            }
            else if (ButtonPressed != "M")
            {
                Console.WriteLine("Please, type 'M' if you wanna get back to the menu");
            }
        }
    }

    public override string ToString()
    {
        return "" + Game + " R$" + Price;
    }

    public static void CreateTitle(string title)
    {
        int numberOfLetters = title.Length;
        string symbols = string.Empty.PadLeft(numberOfLetters, '-');

        Console.WriteLine(symbols);
        Console.WriteLine(title);
        Console.WriteLine(symbols);
    }

}
