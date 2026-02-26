using System.Linq.Expressions;

internal class Program
{
    private static void Main(string[] args)
    {
        int numbers = 0;
        int many;
        string symbol = "";
        double total;

        Console.Write("How many numbers u want: ");
        many = int.Parse(Console.ReadLine());

        for (int i = 1; i < many; i++)
        {
            Console.Write(i + "* number: ");
            many = int.Parse(Console.ReadLine());
        }

        total = FlexibleCalculator(symbol, numbers);

        Console.WriteLine(total);

        Console.ReadKey();
    }
    static double FlexibleCalculator( string symbol, params int[] numbers)
    {
        int total = 0;

        foreach (int n in numbers)
        {
            Console.WriteLine("You wanna +, -, * or / ?");
            symbol = Console.ReadLine();

            if (symbol == "+")
            {
                total = n + n;
            }
            else if (symbol == "-")
            {
                total = n - n;
            }
            else if (symbol == "*")
            {
                total = n * n;
            }
            else if (symbol == "/")
            {
                total = n / n;
            }
        }
        return total;
    }
}