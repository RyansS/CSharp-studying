
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

List<Account> AccsInfo = new List<Account>();

Games.CreateTitle("Welcome to steam!");

Games.SeeOffers();
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

        var findLogin = AccsInfo.FirstOrDefault(x => x.Email == tempEmail && x.Password == tempPassword);

        if (findLogin != null)
        {
            Console.WriteLine("You're logged in!");
            Games.Menu();
        }

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
    static List<Games> AllGames = new List<Games>();
    static List<Games> GamesOnCart = new List<Games>();
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

    public static void Menu()
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
                Games.SeeOffers();
                break;
            case "2":

                break;
            case "3":

                break;
            case "4":

                break;
        }
    }



    public static void Cart ()
    {

    }

    public static void SeeOffers()
    {

        

        AllGames.Add(new Games("Counter Strike 2", 0));
        AllGames.Add(new Games("Dark Souls 3", 119.99));
        AllGames.Add(new Games("Cyberpunk 2077", 169.99));
        AllGames.Add(new Games("Red Dead Redemption 2", 199.99));
        AllGames.Add(new Games("Hollow Knight", 39.99));


        CreateTitle("Check out the offers of the week!");
        for (int i = 0; i < AllGames.Count; i++)
        {
            Console.WriteLine(AllGames[i].ToString());
        }

        Console.WriteLine("\nIf you want any game, type the name of it and it'll be added to the cart: ");
        string nameOfTheGame = Console.ReadLine();

        var findGame = AllGames.FirstOrDefault(GameExpects => GameExpects.Game == nameOfTheGame); //it returns
                                                                                                  //the Game
                                                                                                  //itself searching by name

        if (nameOfTheGame == "")
        {
            Console.WriteLine("Please type the name of a game!");
            Console.Clear();
            SeeOffers();
        }
        else if (nameOfTheGame != "" && findGame != null)
        {
            Console.WriteLine("Do you wanna add another game? (Y/N) ");
            string answerAddGame = Console.ReadLine();
            answerAddGame.ToLower();

            if (findGame == null)
            {
                Console.WriteLine("We didn't find this game...");
                Console.Clear();
                SeeOffers();
            }


            if (answerAddGame == "y")
            {
                SeeOffers();
            }
            else if (answerAddGame == "n")
            {
                GetbackToMenu();

            }
        }

        GetbackToMenu();

    }

    void AddGamesToCart(string nameOfTheGame)
    {

    }

    public static void GetbackToMenu ()
    {

        bool repeat = true;

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
