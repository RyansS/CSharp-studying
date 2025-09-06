using System.Runtime.Intrinsics;

internal class Program
{
    private static void Main(string[] args)
    {
        int v1;// first value
        int v2;// second value
        int result; // the result of the sum

        Console.Write("Enter the 1st value: ");
        v1 = int.Parse(Console.ReadLine()); 

        Console.Write("Enter the 2nd value: ");
        v2 = int.Parse(Console.ReadLine());

        result = sum(v1, v2); // i created the result to store the return of the sum method

        Console.WriteLine("The result is: " + result);

        Console.ReadKey();
    }
    static int sum(int v1, int v2) // here v1 and v2 will be added by each other and the R will store this value
    {
        int r = v1 + v2;
        return r; //this value will be returned in the main method
    }
}