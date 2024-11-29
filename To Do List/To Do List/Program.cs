
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> actions = new List<string>();
        bool again = true;
        string done = "";

        Asc(actions, again, done);

        Console.ReadKey();
    }
    static void Asc(List<string> actions, bool again, string done)
    {
        Console.WriteLine("Welcome, dear user");
        Console.WriteLine("What's coming up for today? ");
        Console.WriteLine("If you wanna show you're to do list, type: show");

        while (again)
        {
            actions.Add(Console.ReadLine());

            if (actions.Contains("show") || actions.Contains("Show") || actions.Contains("SHOW"))
            {
                actions.Remove("show");

                Console.WriteLine("Here's you're to do list: ");
                Console.WriteLine("Type if the actions are made or no by using y or n ");
                foreach (string show in actions)
                {
                    Console.WriteLine(show);
                    for (int i = 0; i < actions.Count; i++)
                    {
                       done = Console.ReadLine();
                       done.ToLower();
                        if (done == "y")
                        {
                            Console.WriteLine("This action is completed!");
                        }
                        else if (done == "n")
                        {
                            Console.WriteLine("This action isn't completed!");
                        }
                    }
                }
                again = false;
            }
        }
    }
}