
internal class Program
{
    private static void Main(string[] args)
    {
      
        bool again = true;
        string answer;
        List<string> lista = new List<string>();

        while (again)
        {
            answer = "";
            Console.Write("What song do u wanna listen to? ");
            lista.Add(Console.ReadLine());

                Console.Write("Do you wanna add other song? (Y/N)");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    again = true;
                }

                else
                {
                    again = false;
                    Console.Write("Here's you're list: ");
                for (int i = 0; i < lista.Count; i++) // here i should used the foreach loop but it's ok
                {
                    Console.WriteLine("\n" + lista[i]); //it will show the storages of the list and it will stop
                }
            }

        }
        Console.ReadKey();
        }
    }
