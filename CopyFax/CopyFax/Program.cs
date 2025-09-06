internal class Program
{
    private static void Main(string[] args)
    {
        int num1 = 0;
        int num2 = 0;

        Console.Write("Insert the first number:");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Insert the second number:");
        num2 = int.Parse(Console.ReadLine());

        int temp = num1; // the temporary variable stores the old value of num1 so num2 can take this value


        num1 = num2;
        num2 = temp;


        Console.WriteLine("1st: " + num1 + " 2nd: " + num2);
        
    }
}