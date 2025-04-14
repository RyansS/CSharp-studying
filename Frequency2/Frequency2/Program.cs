internal class Program
{
    private static void Main(string[] args)
    {
        int num1 = 0;
        int num2 = 0;

        int result = 0;

        Console.WriteLine("1st nmb:");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("2nd nmb:");
        num2 = int.Parse(Console.ReadLine());

        result = num1 + num2;

        Console.WriteLine(result);

        Console.ReadKey();
    }
}