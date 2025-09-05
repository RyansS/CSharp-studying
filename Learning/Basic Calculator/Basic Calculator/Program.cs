internal class Program
{
    private static void Main(string[] args)
    {

        double result = Calculator();

        Console.WriteLine("You're result is: " + result);

        Console.ReadKey();
    }
    public static double Calculator() //Method for the calculator
    {
        Console.Write("Type the 1st number: "); //asks the 1st number to the user
        double nmb1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Choose a operator: * / + - "); //make the user choose the operator
            string operate = Console.ReadLine();

                Console.Write("Type the 2nd number: "); //make him choose the 2nd operator
                double nmb2 = double.Parse(Console.ReadLine());



        if (operate == "*") // A case for each operator
        {
            return nmb1 * nmb2; //if the operator matches so it's gonna return the operation
        }

            else if (operate == "/")
            {
                return nmb1 / nmb2;
            }

                else if (operate == "+")
                {
                    return nmb1 + nmb2;
                }

                    else if (operate == "-")
                    {
                        return nmb1 - nmb2;
                    }

        throw new ArgumentException("Invalid operator!"); // This forces an error because your method must return a value in every possible case.
    }
}