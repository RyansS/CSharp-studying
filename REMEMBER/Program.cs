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

    public void ShowBalance (string username) {
        Console.Clear();

        Console.WriteLine("Type the username and it's balance will be shown: ");
        string answer = Console.ReadLine();

        if (answer == username)
        {
            
        }
    }
}