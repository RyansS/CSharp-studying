
using Steam_App_Login;
using System.Net;

internal class Program
{
    private static void Main(string[] args)
    {
        string sign = "";
        string email = "";
        string user = "";
        string pass = "";
        bool again = true;
        string answer = "";
        string game = "";
        List<string> users = new List<string>(); //list created for the usernames
        List<string> emails = new List<string>(); //list created for the emails
        List<string> passwords = new List<string>(); // and the list for the passwords
        List<string> cart = new List<string>();
        int[] prices = { 130, 150, 50 };

        while (again) //this loop keeps the login running
        {
            login(sign, user, email, pass, answer, users, emails, again, passwords, cart, prices); //the method used to create the login
        }
    }
    static void login(string sign, string user, string email, string pass, string answer, List<string> users, List<string> emails, bool again, List<string> passwords, List<string> cart, int[] prices) //all the params in order
    {
        Console.WriteLine("Welcome to Steam!");
        Console.WriteLine("Do you want to sign up, sign in or Exit?"); //depending of the answer it will run different block of code
        sign = Console.ReadLine();

        if (sign == "sign up" || sign == "signup")
        {
            Console.WriteLine("Let's register you!");
            Console.WriteLine();
            Console.Write("User: ");
            user = Console.ReadLine(); //the username that you wrote will be stored in the variable used

                if (users.Contains(user)) //this command check if the list users contains the variable user
                {
                    Console.WriteLine("This user already exists!");
                }
                else if (emails.Contains(email)) //the same thing here 
                {
                    Console.WriteLine("This email is already being used!");
                }

            Console.WriteLine();
            Console.Write("Email: ");
            email = Console.ReadLine(); //storing the email

            Console.WriteLine();
            Console.Write("Password: ");
            pass = Console.ReadLine(); //storing the passwords

            //after this te answers will be stored in the lists
            users.Add(user);
            emails.Add(email);
            passwords.Add(pass);

            if (user != "" && email != "" && pass != "") //if the user, email and the password are different from a empty string you will be logged
            {
                pagamento(user, prices, cart);
                Console.Write("Type the action that you want to do: Log Out - Add User - Exit");
                answer = Console.ReadLine();

                if (answer == "Logout" || answer == "Log out" || answer == "Log Out" || answer == "logout") //depending of the answer the login will repeat
                {
                    again = true;
                }
                else if (answer == "Add User" || answer == "Add user" || answer == "adduser")
                {
                    again = true;
                }
                else if (answer == "Exit" || answer == "exit")
                {
                    again = false;
                }
            }

            else if (user.Length < 3 || user.Length > 25) //if the name of the used is too long it won't log in
            {
                Console.WriteLine("Please, enter a valid username! (No less than 3 chars or more than 15 chars)");
            }

            else if (pass.Length < 8) //if the name of the used is too short it won't log in
            {
                Console.WriteLine("For you're security, make a password with more than 8 characters!");
            }

        }
        else if (sign == "sign in" || sign == "signin") // this is the sign in, you must have created a user before logging 
        {
            Console.WriteLine("Welcome Back!");

            Console.Write("What's you're user? ");
            user = Console.ReadLine();

            while (user.Length <3 || user.Length > 25) //i used the while loop to, if the user be short or too long it will keep asking the user
            {
                Console.Write("What's you're user? ");
                user = Console.ReadLine();
            }

            Console.Write("What's you're email? ");
            email = Console.ReadLine();

            Console.Write("What's you're password? ");
            pass = Console.ReadLine();

            if (users.Contains(user) && emails[users.IndexOf(user)] == email && passwords[users.IndexOf(user)] == pass) //now it's a hard part of the code
            {
                pagamento(user, prices, cart, game);
            }
            else
            {
                    Console.WriteLine("You're user or you're email are incorrect! Or maybe you don't have a account yet");
            }
        }
        else if (sign == "exit")
        {
            again = false;
        }
    }
    static void pagamento(string user, int[] prices, List<string> cart, string game)
    {
        Games hollowk = new Games("Hollow Knight", 50);
        Games sekiro = new Games("Sekiro Shadows Die Twice", 150);
        Games darksouls = new Games("Dark Souls 3", 190);

        Console.WriteLine("Welcome, " + user + " to the Steam!"); //if the users have the variable user and the email in the users position is equal to email it will log in
        Console.WriteLine("Offers of the week!");

        hollowk.show();
        sekiro.show();
        darksouls.show();

        Console.WriteLine();
        Console.WriteLine("For choose one, type the name of the game and it will be added, if you want to buy type 'buy' ");
        game = Console.ReadLine();

        if (game == "Hollow Knight")
        {
            
        }

            foreach (string v in cart)
            {
                Console.WriteLine("Here are you're games: " + v);
            }
        }
    }
}