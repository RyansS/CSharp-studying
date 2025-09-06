internal class Program
{
    private static void Main(string[] args)
    {
        Thread mainThread = Thread.CurrentThread; 
        mainThread.Name = "Main Thread";

        Thread thread1 = new Thread(CountUp1);
        Thread thread2 = new Thread(CountUp2);
        thread1.Start();
        thread2.Start();


    }

    public static void CountUp1()
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }

    public static void CountUp2()
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }
}