using System;

internal class Program
{
    private static void Main()
    {
        Triangle();
    }

    private static void Triangle()
    {
        Console.Write("How many columns? ");
        int columns = int.Parse(Console.ReadLine());

        for (int i = 1; i <= columns; i++)
        {
            for (int j = 0; j < i; j++) // Inner loop to print stars
            {
                Console.Write("*");
            }
            Console.WriteLine(); // Move to the next line
        }
    }
}
