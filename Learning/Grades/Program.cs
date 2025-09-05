
using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("What is the grade from the student? ");
        int grades = Convert.ToInt32(Console.ReadLine());


        if (grades < 5)
        {
            Console.WriteLine("You're reproved, better luck next time.");
        }
        else
        {
            Console.WriteLine("You're aproved!");
        }


        Console.ReadKey();
    }
}