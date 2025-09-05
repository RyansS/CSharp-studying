using System.Transactions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Which day is today?");
        int day = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Which month?");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Which year?");
        int year = Convert.ToInt32(Console.ReadLine());

        if (day > 31)
        {
            Console.WriteLine("Enter a valid day");
        }
        else if (month > 12)
        {
            Console.WriteLine("Enter a valid month");
        }
        else if (year >2100)
        {
            Console.WriteLine("Please enter a year above 2100");
        }
        else
        {
            Console.WriteLine("Please enter a data");
        }

        Console.WriteLine("The data of today is: " + day + "/" + month + "/" + year);

        Console.ReadKey();
    }
}