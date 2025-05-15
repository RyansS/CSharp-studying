internal class Program
{
    private static void Main(string[] args)
    {
        int n = 0;

        int[] values = {100, 50, 20, 10, 5, 2, 1};


        Console.WriteLine("How much money?/n");
        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < values.Length; i++)
        {
            n/values[i];
        }

        Console.ReadKey();
    }
        
    }