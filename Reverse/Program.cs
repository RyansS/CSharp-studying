using System.ComponentModel.DataAnnotations.Schema;

internal class Program
{
    private static void Main(string[] args)
    {
        string ans;

        Console.Write("Enter something: "); 
        ans = Console.ReadLine();

        char[] chars = ans.ToCharArray(); //here we create a char array and convert the answer to a char array
        Array.Reverse(chars); //i used a function named Array.Reverse() to reverse what else was written
        string reverse = new string(chars); //here i create this string and take the values of chars

        Console.WriteLine("Reverse: " + reverse);
        Console.ReadKey();
    }
}