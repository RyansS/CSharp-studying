Console.WriteLine("- Welcome to Steam -");

class User
{
    public string Username {get; private set;}

    public string Email {get; private set;} 

    public string Password {get; private set;}

    public int Age {get; set;}


    public User (string username, string email, string password, int age)
    {
        Username = username;
        Email = email;
        Password = password;
        Age = age;
    }

    public User Register () {
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
}