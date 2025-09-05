internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("What number do u wanna reach?");
        int reach = Convert.ToInt32(Console.ReadLine());

        for (int macaco = 0; macaco <= reach; macaco+=2) // the for loop you set when it will stop. it's not as the same as the while loop which only stop when the value cames false so it stop
        {
            Console.WriteLine();
            Console.Write(macaco);
        }




        Console.ReadKey();
    }
}