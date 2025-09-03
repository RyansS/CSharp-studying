
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    
    private static void Main(string[] args)
    {
        Games.CreateTitle("Welcome to steam!");

            Games.AllGames.Add(new Games("Counter Strike 2", 0));
                Games.AllGames.Add(new Games("Dark Souls 3", 119.99));
                    Games.AllGames.Add(new Games("Cyberpunk 2077", 169.99));
                        Games.AllGames.Add(new Games("Red Dead Redemption 2", 199.99));
                            Games.AllGames.Add(new Games("Hollow Knight", 39.99));

        Account.Login(Account.AccsInfo);

        Console.ReadKey();
    }
}

class Account
{
    public static List<Account> AccsInfo = new List<Account>();
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

    public static Account Register()
    {
        Console.Write("How we should call you? ");
        string TempUsername = Console.ReadLine();

        Console.WriteLine("\nNow we need some crucial informations from you ");

        Console.Write("\nWhat's your email? ");
        string TempEmail = Console.ReadLine();

        Console.Write("\nNow create a strong password: ");
        string TempPassword = Console.ReadLine();

        if (TempUsername != null && TempEmail != null && TempPassword != null)
        {
            Console.Clear();
            Console.WriteLine("Thank you to join the Steam universe!");

        }
        else if (TempUsername == null || TempEmail == null || TempPassword == null)
        {
            Console.WriteLine("\nPlease, keep sure that you've typed you're" +
                " credentials properly");
            Register();
        }

        return new Account(TempUsername, TempEmail, TempPassword);
    }

    public static void Login(List<Account> ListOfAccounts)
    {
        Console.Clear();
        Games.CreateTitle("Welcome to Log-in!");
        Console.WriteLine("\nIf you're not a member yet type: 'Register', in case you're already a member, type: 'Login'");

        string option = Console.ReadLine();
        option.ToLower();

        if (option == "register")
        {
            Account acc = Register();
            ListOfAccounts.Add(acc);
            Login(ListOfAccounts);
        }
        else if (option == "login")
        {

            Console.Write("Type here you're email: ");
            string tempEmail = Console.ReadLine();

            Console.Write("\nEnter password: ");
            string tempPassword = Console.ReadLine();

            var findLogin = ListOfAccounts.FirstOrDefault
            (EachItemOfList => EachItemOfList.Email == tempEmail && EachItemOfList.Password == tempPassword);


            if (findLogin != null)
            {
                Console.Clear();
                Console.WriteLine("You're logged in!");
                Games.Menu();
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Your credentials doesn't match...");
                Console.ReadLine();
                Login(AccsInfo);
            }
        }
    }
}

class Games
{
    public static List<Games> AllGames = new List<Games>();
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
        nextId++;
    }

    public static void Menu()
    {

        CreateTitle("Welcome to the Steam homepage!");
            Console.WriteLine("1 - See offers");
                Console.WriteLine("2 - Go to cart");
                    Console.WriteLine("3 - Library");
                        Console.WriteLine("4 - Profile\n");

        string option = Console.ReadLine();

        switch (option)
        {
            case "1":
                SeeOffers();
                break;
            case "2":
                Cart();
                break;
            case "3":
                Library();
                break;
            case "4":
                Profile(Account.AccsInfo);
                break;
        }
    }
    public static void SeeOffers()
    {

        Console.Clear();

        CreateTitle("Check out the offers of the week!");

            foreach (Games ShowGamesOffers in AllGames)
            {
                Console.WriteLine(ShowGamesOffers.ToString());
            }

        Console.WriteLine("\nType the name of the game and it'll be added to the cart: ");
        string nameOfTheGame = Console.ReadLine();

        AddGamesToCart(nameOfTheGame);

        GetbackToMenu();
    }

    public static void Cart()
    {
        Console.Clear();
        CreateTitle("Welcome to the Cart!");

        Console.WriteLine("The games on your cart:\n");

        foreach (Games ShowGamesOnCart in GamesOnCart)
        {
            Console.WriteLine($"Name: {ShowGamesOnCart.Game}, Price: {ShowGamesOnCart.Price}");
        }

        Console.WriteLine("Would u like to go to the payment?(Y/N)");
        string answerGoToPay = Console.ReadLine();
        answerGoToPay.ToUpper();

        if (answerGoToPay == "Y")
        {
            Console.WriteLine("Total: " + Payment());
        }

        else if (answerGoToPay != "y" || answerGoToPay == "")
        {
            Console.Clear();
            Menu();
        }
    }

    public static void Library()
    {
        Console.Clear();
        CreateTitle("Welcome to your Library");

        Console.WriteLine("Here is shown all your games");

        foreach (Games ShowLibraryGames in AllGames)
        {
            Console.WriteLine($"{ShowLibraryGames.Game} ---> PLAY");
        }

        Console.WriteLine("\nType 'PLAY' if you'd like to play");
    }

    public static void Profile (List<Account> AccountList)
    {
        CreateTitle("Profile");

        Console.WriteLine("You're credentials: ");

            foreach (Account ShowAllInfo in AccountList)
            {
                Console.WriteLine($" Username: {ShowAllInfo.User}\n Email: {ShowAllInfo.Email}\n Password: {ShowAllInfo.Password}");
            }
    }

    public static double Payment()
    {
        Console.Clear();
        double totalSum = 0;

        CreateTitle("Payment");

        foreach (Games ShowGamesOnCart in GamesOnCart)
        {
            Console.WriteLine($"Name: {ShowGamesOnCart.Game}, Price: {ShowGamesOnCart.Price}");

                totalSum += ShowGamesOnCart.Price;

        }

        Console.Write("\nChoose the payment method:\n");
        Console.WriteLine("Credit card");
        Console.WriteLine("Pix");
        Console.WriteLine("Nomad\n");

        return totalSum;
    }

    public static void AddGamesToCart(string nameOfTheGame)
    {
        var findGame = AllGames.FirstOrDefault(GameExpects => GameExpects.Game == nameOfTheGame); //it returns
                                                                                                  //the Game
                                                                                                  //itself searching by name
        if (nameOfTheGame == "" || findGame == null)
        {
            Console.WriteLine("We didn't find this game...\n");
        }
        else if (nameOfTheGame != "" && findGame != null)
        {
            GamesOnCart.Add(findGame);

            Console.WriteLine("Do you wanna add another game? (Y/N) ");
            string answerAddGame = Console.ReadLine();
            answerAddGame.ToLower();

            if (answerAddGame == "y")
            {
                Console.Clear();
                SeeOffers();
            }
            else if (answerAddGame == "n")
            {
                GetbackToMenu();
            }
        }
    }

    public static void GetbackToMenu ()
    {

        bool repeat = true;

        while (repeat)
        {
            Console.WriteLine("Get back to the menu by pressing 'M' ");
            string ButtonPressed = Console.ReadLine();
            ButtonPressed.ToLower();

            if (ButtonPressed == "m")
            {
                repeat = false;
                Console.Clear();
                Menu();
            }
            else if (ButtonPressed != "m")
            {
                Console.WriteLine("Please, type 'M' if you wanna get back to the menu");
            }
        }

    }

    public override string ToString()
    {
        return $"Name: {Game},  R${Price}";
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
