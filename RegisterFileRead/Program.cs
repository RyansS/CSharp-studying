using System.Text.Json;

Console.WriteLine("- Welcome to Steam -");

User.Menu();

// User UserReturned = User.Register();
// User.UsersCreated.Add(UserReturned);

// string json = JsonSerializer.Serialize(UserReturned);
// File.WriteAllText(@"C:\Users\monte\Desktop\tghd\Users.txt", json);

// User.ReadJsonFile();

class User
{
    public string Username {get; private set;}

    public string Email {get; private set;} 

    public string Password {get; private set;}

    public int Age {get; set;}

    internal static List<User> UsersCreated = new List<User>();

    public User (string username, string email, string password, int age)
    {
        Username = username;
        Email = email;
        Password = password;
        Age = age;
    }

    public static User Register () {
        int AgeInput;
        string UserInput;
        string EmailInput;
        string PasswordInput;


        Console.WriteLine("- Register -\n");

        while (true)
        {
        Console.Write("- Username: ");
        UserInput = Console.ReadLine();

        Console.Write("- Email: ");
        EmailInput = Console.ReadLine();

        Console.Write("- Password: ");
        PasswordInput= Console.ReadLine();

        Console.Write("- Age: ");
        int.TryParse(Console.ReadLine(), out AgeInput);

        if (UserInput.Length >= 5 && EmailInput.Length >= 10 && PasswordInput.Length > 7) 
            {
                break;
            }
        }


        return new User (UserInput, EmailInput, PasswordInput, AgeInput);

    }

    public static void Login () {
        Console.WriteLine("- Login - ");
        string path = @"C:\Users\monte\Desktop\tghd\Users.txt";
        string inputemail;
        string inputpassword;

        Console.WriteLine("Email: ");
        inputemail = Console.ReadLine();

        Console.WriteLine("Password: ");
        inputpassword = Console.ReadLine();

        if (File.Exists(path) && inputemail != null && inputpassword != null)
        {
            string jsonfileUser = File.ReadAllText(path);
            
            User loadUser = JsonSerializer.Deserialize<User>(jsonfileUser);

            if (loadUser.Email == inputemail && loadUser.Password == inputpassword)
            {
                Console.WriteLine("You're logged in!");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("- Welcome to Steam! -");
            }
            else
            {
                Console.WriteLine("We had a problem...");
            }
        }

    }

    public static void Menu ()
    {
        Console.WriteLine("1- Login");
        Console.WriteLine("2- Register");

        Console.WriteLine("");
        string input = Console.ReadLine();

        if (input == "1")
        {
            Login();
        }
        else if (input == "2")
        {
            Register();
        }
    }

    public static void ReadJsonFile () {
        string path = @"C:\Users\monte\Desktop\tghd\Users.txt";

        if (File.Exists(path))
        {
            string JsonFile = File.ReadAllText(path);

            User loadedUser = JsonSerializer.Deserialize<User>(JsonFile);
        }
        else
        {
            Console.WriteLine("We didn't find the user...");
        }
    }
}