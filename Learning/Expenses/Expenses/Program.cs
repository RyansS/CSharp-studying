
using Expenses;
using System.Collections.Generic;
using System.Reflection;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> name = new List<string>();
        List<string> category = new List<string>();
        List<int> amount = new List<int>();
        bool again = true;
        int choice;

        Console.WriteLine("1.Add a new expense");
        Console.WriteLine("2.View all expenses");
        Console.WriteLine("3.Calculate total expenses");
        Console.WriteLine("4.Filter expenses by category");

        choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                add(name,
                    category,
                    amount);
                break;
            case 2:
                foreach (string n in name)
                {
                    Console.WriteLine(n);
                }
                break;
            case 3:
                break;
            case 4:
                break;

        }


        while (again)
            {
                


                Console.WriteLine("What's the expense category?");
                category.Add(Console.ReadLine());

                Console.WriteLine("What's the expense amount?");
                amount.Add(int.Parse(Console.ReadLine()));

                if (name.Contains("stop") || category.Contains("stop"))
                {
                    again = false;
                    name.Remove("stop");
                    category.Remove("stop");
                    Console.WriteLine("Here are you're expenses:");

            }

        }
        Console.ReadKey();
    }

    public void add(List<string> name, List<string> category, List<int> amount)
    {
        Console.Write("Expense name:");
        name.Add(Console.ReadLine());

        Console.Write("Expense category:");
        category.Add(Console.ReadLine());

        Console.Write("Expense amount:");
        amount.Add(int.Parse(Console.ReadLine()));
    }
    static void calculate()
    {

    }
}