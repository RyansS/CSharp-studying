Console.WriteLine("Welcome to the bank");

class Bank
{
    public decimal Balance { get; set;}
    public string Username {get; set;}

    public Bank (decimal balance, string username)
    {
        Balance = balance;
        Username = username;
    }

    public Bank Register ()
    {
        Console.WriteLine("Register yourself: \n");
        Console.Write("Name: ");
        string name = Console.ReadLine();

        return new (0, name);
    }