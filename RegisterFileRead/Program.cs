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
}