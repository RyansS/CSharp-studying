using System.Reflection.Metadata;
using System.Transactions;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> users = new List<string>();
        List<string> passwords = new List<string>();
        List<string> songs = new List<string>();
        string relog = "";
        bool again = true;
        string entlogin = "";
        string entpass = "";

        login(
            users, passwords, songs, relog, again, entlogin, entpass);

        Console.ReadKey();
    }

   public static void login(List<string> users, List<string> passwords,
       List<string> songs, string relog, bool again, string entlogin, string entpass)
    {
        Console.WriteLine("U will login or register? (L/R)");
        relog = Console.ReadLine();
        relog = relog.ToUpper();

        while (again)
        {
            if (relog == "L")
            {
                Console.Write("Enter ur Username: ");
                entlogin = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Enter ur Password: ");
                entpass = Console.ReadLine();


                if (users.Contains(entlogin) && passwords.Contains(entpass))
                {
                    again = false;
                    spotlist(songs, entlogin);
//IMPORTANT         
                }
                else
                {
                    Console.WriteLine("Your user or your password doesnt match in the login!");
                }
            }
            else if (relog == "R")
            {
                Console.Write("Which will be ur username? ");
                entlogin = Console.ReadLine();
                if (users.Contains(entlogin))
                {
                    users.Remove(entlogin);
                }
                else
                {
                    users.Add(entlogin);

                    Console.WriteLine("Which will be ur password? ");
                    entpass = Console.ReadLine();
                    if (users.Contains(entpass))
                    {
                        users.Remove(entpass);
                    }
                    else
                    {
                        users.Add(entpass);
                    }
                }

                Console.WriteLine();

                
            }
        }    
    }

    public static void spotlist(List<string> songs, string entlogin)
    {
        Console.WriteLine("Welcome back, " + entlogin + " what your gonna listen today?");
        Console.WriteLine("");
    }
}