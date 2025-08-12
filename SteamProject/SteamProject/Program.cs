
Console.WriteLine("Welcome to steam!");

static void Register ()
{
    bool repeat = false;

    while (repeat)
    {

        Console.Write("How we should call you? ");
        string username = Console.ReadLine();

        Console.WriteLine("Now we need some crucial informations from you ");

        Console.Write("What's your email? ");
        string email = Console.ReadLine();

        Console.Write("\nNow create a strong password: ");
        string password = Console.ReadLine();

        if (username != null && email != null && password != null)
        {
            Console.WriteLine("\nThank you to joined the Steam universe!");
            repeat = false;
        }
        else
        {
            Console.WriteLine("\nPlease, keep sure that you've typed you're" +
                " credentials properly");
            repeat = true;
        }
    }
} 