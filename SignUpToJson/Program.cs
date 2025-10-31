using System;
using System.IO;
using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        UtilityMethod.Users.Add(SignUp.SignUpMethod());
        SelectedUsers.GenerateJson();

        Console.ReadKey();
    }
}

class UtilityMethod
{
    public static List<SignUp> Users = new();
    public static void CreateTitle(string title)
    {
        int numbCharacters = title.Length;
        string symbol = string.Empty.PadLeft(numbCharacters, '*');

        Console.WriteLine(symbol);
        Console.WriteLine(title);
        Console.WriteLine(symbol);

    }
}

class SignUp
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public SignUp(string name, string email, string password)
    {
        Name = name;
        Email = email;
        Password = password;
    }


    public static SignUp SignUpMethod()
    {

        UtilityMethod.CreateTitle("Welcome to sign up!");

        Console.WriteLine("Username: ");
        string usernick = Console.ReadLine();

        Console.WriteLine("Email: ");
        string email = Console.ReadLine();

        Console.WriteLine("Password: ");
        string password = Console.ReadLine();

        return new SignUp(usernick, email, password);
    }

}

class SelectedUsers
{

    public static void GenerateJson ()
    {
        string FileValue = JsonSerializer.Serialize(UtilityMethod.Users);

        File.WriteAllText("users-archive-info.json", FileValue);

        Console.WriteLine("The Json file was created successfully!");
    }
    
}