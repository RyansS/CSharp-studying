
using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> inventory = new List<string>();// creating the inventory
        string action; //the action that you're going to do
        bool gain = true; // it keeps the question of add edit or remove 
        
        while (gain)
        {
            Console.Write("Add, Edit or Remove something of you're inventory? (Type the action) "); 
            action = Console.ReadLine(); //it stores the action
            action = action.ToLower(); //put the case to lower even if the user types in capslock

            if (action == "n" || action == "no") //here is the if statement case the user says "no"
            {
                foreach (string v in inventory) // i used a foreach to show easier the inventory
                {
                    Console.WriteLine("Here's you're list: "); //just show the list
                    Console.WriteLine(v);//just show the list
                }
                gain = false; // if the user types "no" the inventory will end
            }

            else if (action == "add") // here is the action of add
            {
                Console.Write("Add: ");
                inventory.Add(Console.ReadLine()); //it adds what you type as a string
            }
            else if (action == "remove") // it's the remove
            {
                foreach (string v in inventory) // i used a foreach to show the inventory before the user remove something
                {
                    Console.WriteLine(v);
                }
                Console.Write("Remove: ");
                inventory.Remove(Console.ReadLine()); //again, the user must type what he wanna remove
            }
            else if (action == "edit") //the edit action is more complex
            {
                foreach (string v in inventory) //first i show the inventory
                {
                    Console.WriteLine(v);
                }
                Console.Write("Edit what? "); // ask the user what he wanna edit
                inventory.Remove(Console.ReadLine()); //and he types what he wanna edit, but it removes it first
                Console.Write("Now edit: "); //so now the edit is an inventory.add but it works
                inventory.Add(Console.ReadLine()); 
            }
            else
            {
                Console.WriteLine("Please enter a valid action!"); // and if you don't type something equal to the actions it will show you this message
            }

        }


        Console.ReadKey();
    }
}