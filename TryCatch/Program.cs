Console.WriteLine("- Divider");
bool Isvalid = false;
bool numberValid = false;
int number1 = 0;
int number2 = 0;


try
{
    while (!Isvalid)
    {

        Console.Write("- Number 1: ");
    numberValid = int.TryParse(Console.ReadLine(), out number1);

        Console.Write("- Number 2: ");
    numberValid = int.TryParse(Console.ReadLine(), out number2);

        if (!numberValid)
        break;

    Console.WriteLine("Invalid calculation!");

    }
    
}

catch (FormatException ex)
{
    Console.WriteLine($"A calculator only accept numbers! {ex.Message}");
}

catch (DivideByZeroException ex)
{
    Console.WriteLine($"You can't divide a number by zero! {ex.Message}");
}

double result = number1 / number2;

Console.WriteLine($"The result is: {result}");




        