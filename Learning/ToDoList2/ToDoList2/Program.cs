internal class Program
{
    private static void Main(string[] args)
    {
        List<string> todo = new List<string>();
        int choose;
        bool repeat = true;

        while(repeat)
        {
        Console.WriteLine("");
            Console.WriteLine("1. Add new to do");
                Console.WriteLine("2. Remove to do");
                    Console.WriteLine("3. Show to do and end");
                        Console.WriteLine("4. Delete all to do");
                            Console.WriteLine("");

            choose = int.Parse(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    add(todo);
                    break;
                    case 2:
                        remove(todo);
                        break;
                        case 3:
                            show(todo);
                            repeat = false;
                            break;
                            case 4:
                                delete(todo);
                                break;
            }

        }

        Console.ReadKey();
    }
    static void add(List<string> todo)
    {
        Console.Write("Add: ");
        todo.Add(Console.ReadLine());
    }

    static void remove(List<string> todo)
    {
        Console.WriteLine("");
        Console.WriteLine("Remove something by writing");
        Console.WriteLine("");

        foreach (string sh in todo)
        {
            Console.WriteLine(sh);
        }
        Console.WriteLine("");
        Console.Write("Remove: ");
        todo.Remove(Console.ReadLine());
    }
    
    static void show(List<string> todo)
    {
        Console.WriteLine("");
        Console.WriteLine("Here's you're to do list:");

        foreach(string sh in todo)
        {
            Console.WriteLine(sh);
        }
    }

    static void delete(List<string> todo)
    {
        todo.Clear();
        Console.WriteLine("You're list was deleted!");
    }
}