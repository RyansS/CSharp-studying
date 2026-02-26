using System.Net.Http.Headers;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> users = new List<string>(); // i created a list to the users
        string check; //it checks the user
        bool again = true; // for keep asking what's the user
        string ans; //it's the answer if you wanna add other user
        int errors = 0; //this is the errors, it's used to don't repeat the users

        while (again)
        {
            Console.Write("What's the name of you're user? ");
            check = Console.ReadLine();

            foreach (string v in users) //create a foreach to use easily the users
            {
                if (v == check) //if what you type in check is equal to something that is whitin the users
                {
                    errors++; //the count of erros will increase
                }
            }

            if (errors > 0) //and if the erros are more than 0 it means that the user is already sign up
            {
                Console.WriteLine("This user was already sign up! ");
                users.Remove(check); //even that the user was added it will remove the user
            }

            if (check != "" && check.Length >= 3 && check.Length <= 10) // here is a limit to the number of chars 
            {
                users.Add(check); //here it will add you're user
            }
            else
            {
                Console.WriteLine("Please enter a name with more than 3 chars!"); //if the name isn't in the range this message will appear
            }

            Console.Write("Do u wanna add other user? (Y/N) "); // so after this all check stuff it will ask if u wanna add other user
            ans = Console.ReadLine();
            ans = ans.ToUpper();

            if (ans == "Y") // if the answer is equal to "yes"
            {
                again = true; //so the program will run another time
            }
            else
            {
                again = false; //if no it will stop running and will show the users stored

                for (int i = 0; i < users.Count; i++)
                {
                    Console.WriteLine("User(s): " + users[i]);
                }
            }
        }
        Console.ReadKey();
    }
}