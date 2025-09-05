internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbs = new int[6];

        Random rand = new Random();
        int v1 = rand.Next(1, 50);
        int v2 = rand.Next(1, 50);
        int v3 = rand.Next(1, 50);
        int v4 = rand.Next(1, 50);
        int v5 = rand.Next(1, 50);
        numbs[1] = v1;
        numbs[2] = v2;
        numbs[3] = v3;
        numbs[4] = v4;
        numbs[5] = v5;

        

        Console.Write(numbs[1]);
        Console.Write("/" + numbs[2]);
        Console.Write("/" + numbs[3]);
        Console.Write("/" + numbs[4]);
        Console.Write("/" + numbs[5]);

        Console.ReadKey();
    }
}