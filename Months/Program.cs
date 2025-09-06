using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] month = { "", "January", "February", "March", "April", "June", "July", "August", "September", "October", "November", "December" };
        int numb;

        Console.Write("Type a number to refer to a month: ");
        numb = int.Parse(Console.ReadLine());

        switch (numb)
        {
            case 1:
                Console.WriteLine("It's " + month[1]);
                break;
            case 2:
                Console.WriteLine("It's " + month[2]);
                break;
            case 3:
                Console.WriteLine("It's " + month[3]);
                break;
            case 4:
                Console.WriteLine("It's " + month[4]);
                break;
            case 5:
                Console.WriteLine("It's " + month[5]);
                break;
            case 6:
                Console.WriteLine("It's " + month[6]);
                break;
            case 7:
                Console.WriteLine("It's " + month[7]);
                break;
            case 8:
                Console.WriteLine("It's " + month[8]);
                break;
            case 9:
                Console.WriteLine("It's " + month[9]);
                break;
            case 10:
                Console.WriteLine("It's " + month[10]);
                break;
            case 11:
                Console.WriteLine("It's " + month[11]);
                break;
            case 12:
                Console.WriteLine("It's " + month[12]);
                break;
        }

        if (numb == 0)
        {
            months(numb, month);
        }

        Console.ReadKey();
    }
    static void months(int numb, string[] month)
    {
        numb = 0;
        while (numb == 0)
        {
            Console.Write("Type a number to refer to a month: ");
            numb = int.Parse(Console.ReadLine());

            switch (numb)
            {
                case 1:
                    Console.WriteLine("It's " + month[1]);
                    break;
                case 2:
                    Console.WriteLine("It's " + month[2]);
                    break;
                case 3:
                    Console.WriteLine("It's " + month[3]);
                    break;
                case 4:
                    Console.WriteLine("It's " + month[4]);
                    break;
                case 5:
                    Console.WriteLine("It's " + month[5]);
                    break;
                case 6:
                    Console.WriteLine("It's " + month[6]);
                    break;
                case 7:
                    Console.WriteLine("It's " + month[7]);
                    break;
                case 8:
                    Console.WriteLine("It's " + month[8]);
                    break;
                case 9:
                    Console.WriteLine("It's " + month[9]);
                    break;
                case 10:
                    Console.WriteLine("It's " + month[10]);
                    break;
                case 11:
                    Console.WriteLine("It's " + month[11]);
                    break;
                case 12:
                    Console.WriteLine("It's " + month[12]);
                    break;
            }
        }


    }
}