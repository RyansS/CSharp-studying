
internal class Program
{
    private static void Main(string[] args)
    {
        double num1 = 0;
        double num2 = 0;
        double result = 0;
        bool conti = true;
        string answer;

        while (conti)
        {
        Console.Write("Enter the 1st value: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the 2nd value: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What operator do u wanna use? ");
        Console.WriteLine("+");
        Console.WriteLine("-");
        Console.WriteLine("*");
        Console.WriteLine("/");
        Console.Write("Enter you're operator: ");

        switch(Console.ReadLine())
        {
            case "+":
                result = num1 + num2;
                Console.WriteLine("You're result is: " + result);
                    break;
            case "-":
                result = num1 - num2;
                Console.WriteLine("You're result is: " + result);
                break;
            case "*":
                result = num1 * num2;
                Console.WriteLine("You're result is: " + result);
                break;
            case "/":
                result = num1 / num2;
                Console.WriteLine("You're result is: " + result);
                break;
        }
            Console.WriteLine("Do you wanna use the calculator again? (Y/N)");
            answer = Console.ReadLine();
            answer = answer.ToUpper();

            if (answer == "Y")
            {
                conti = true;
            }
            else
            {
                conti = false;
            }
    }

        Console.ReadKey();
    }
}