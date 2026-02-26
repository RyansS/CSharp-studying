using System.Security.Principal;

internal class Program
{
    private static void Main(string[] args)
    {

        for (int i = 1; i < 101; i++)
        {
            // Check if the number is divisible by both 3 and 5
            // if the remainder of the number who is being divided is 0 so it's a multiple of 3 or 5
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            // Check if the number is divisible by only 3
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            // Check if the number is divisible by only 5
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            // If none of the above, print the number
            else
            {
                Console.WriteLine(i);
            }
        }
        Console.ReadKey();
    }
}