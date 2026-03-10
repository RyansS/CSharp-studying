

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
    public static void RegisterLogin ()
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

                    UtilityMethods.TitleCreator("Register");

                    Console.WriteLine("Create your Account");

                    Console.Write("Username");
                    string UsernameInput = Console.ReadLine();

                    Console.Write("Email: ");
                    string EmailInput = Console.ReadLine();

                    Console.Write("Password");
                    string PasswordInput = Console.ReadLine();

                    Users NewUser = new Users() ;

                break;

                case 2:
                
                break;

                case 3:
                
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