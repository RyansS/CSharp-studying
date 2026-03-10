
Users.RegisterAndLogin();
class Users
{
    public string Username {get; private set;}

    private string Email {get; set;}
    private string Password {get; set;}

    private static List<Users> AllUsers = new List<Users>();


    public Users (string user, string email, string password)
    {
        Username = user;
        Email = email;
        Password = password;
    }
    public static void RegisterAndLogin ()
    {
        UtilityMethods.TitleCreator("Welcome to DearNote");

        Console.WriteLine("1- Register");
        Console.WriteLine("2- Login");
        Console.WriteLine("3- Exit");

        bool numberValid = int.TryParse(Console.ReadLine(), out int OptionChosen);

        if (numberValid == true)
        {
            switch (OptionChosen)
            {
                case 1:

                    string UsernameInput;
                    string EmailInput;
                    string PasswordInput;

                    UtilityMethods.TitleCreator("Register");

                    Console.WriteLine("Create your Account");

                    do
                    {
                    Console.Write("Username");
                    UsernameInput = Console.ReadLine()!;

                    Console.Write("Email: ");
                    EmailInput = Console.ReadLine()!;

                    Console.Write("Password");
                    PasswordInput = Console.ReadLine()!;

                    if (UsernameInput.Length >= 5 && EmailInput.Length >12 && PasswordInput.Length >7)
                        {
                            break;
                        }

                    }

                    while (true);
                    {
                        Console.Write("Username: ");
                        UsernameInput = Console.ReadLine()!;

                        Console.Write("Email: ");
                        EmailInput = Console.ReadLine()!;

                        Console.Write("Password: ");
                        PasswordInput = Console.ReadLine()!;
                    }
                    
                    Users NewUser = new Users(UsernameInput, EmailInput, PasswordInput) ;
                    AllUsers.Add(NewUser);

                break;

                case 2:

                UtilityMethods.TitleCreator("Login");

                Console.WriteLine("Email: ");
                string LoginInputEmail = Console.ReadLine();

                Console.WriteLine("Password: ");
                string LoginInputPassword = Console.ReadLine();

                var FindAccount = AllUsers.FirstOrDefault(CredentialExpect => CredentialExpect.Email == LoginInputEmail &&
                CredentialExpect.Password == LoginInputPassword);

                if (FindAccount != null)
                    {
                        Console.WriteLine($"Welcome back, dear {FindAccount.Username}");
                    }

                break;

                case 3:

                Console.WriteLine("See you next time!");

                break;
            }
        }
    }
}

class UtilityMethods
{
    public static void TitleCreator (string title)
    {
        int Length = title.Length;
        string symbol = string.Empty.PadLeft(Length, '-');

        Console.WriteLine(symbol);
        Console.WriteLine(title);
        Console.WriteLine(symbol);
    }
}
class NotesApp
{
    private string Note {get; set;}
    private static int NumberOfNotes;

    public static List<string> AllNotes = new List<string>();

    public NotesApp (string Content)
    {
        Note = Content;
        NumberOfNotes ++;
    }

        public void Menu ()
    {
        Console.WriteLine("Welcome, dea");
    }

   
}