using System.Text.Json;

Console.WriteLine("- Welcome to Steam -");

// User UserReturned = User.Register();
// User.UsersCreated.Add(UserReturned);

// string json = JsonSerializer.Serialize(UserReturned);
// File.WriteAllText(@"C:\Users\monte\Desktop\tghd\Users.txt", json);

User.ReadJsonFile();

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

    public void Login () {

    }

    public static void ReadJsonFile () {
        string path = @"C:\Users\monte\Desktop\tghd\Users.txt";

        if (File.Exists(path))
        {
            string JsonFile = File.ReadAllText(path);

            User loadedUser = JsonSerializer.Deserialize<User>(JsonFile);

            Console.WriteLine($"The user {loadedUser.Username} is back!");
        }
        else
        {
            Console.WriteLine("We didn't find the user...");
        }
    }
}