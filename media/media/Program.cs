internal class Program
{
    private static void Main(string[] args)
    {

        media();
        Console.ReadKey();
    }

    public static void media ()
    {
        List<double> grades = new List<double>();

        Console.Write("You're name:");
        string name = Console.ReadLine();

        Console.WriteLine("How many grades? ");
        int manygrades = int.Parse(Console.ReadLine());

        for (int i = 0; i < manygrades; i++)
        {
            Console.WriteLine("Insert the value: ");
            grades.Add(double.Parse(Console.ReadLine()));
        }

        double media = 0;

        foreach (double grade in grades)
        {
            media += grade;
        }
        media /= manygrades;

        Console.WriteLine("Media: " + media);

        if (media >= 5 && media <=10) {
            Console.WriteLine(name + " You're aproved!");
        }
        else if (media <5 && media <=10)
        {
            Console.WriteLine(name + " You're reproved!");
        }
        else
        {
            Console.WriteLine("Enter a valid number!");
        }
    }
}