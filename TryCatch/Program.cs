Console.WriteLine("- Divider");
bool Isvalid = false;
bool numberValid1 = true;
bool numberValid2 = true;
int number1 = 0;
int number2 = 0;
double result = 0;

    while (!Isvalid)
    {
try
{


        Console.Write("- Number 1: ");
    numberValid1 = int.TryParse(Console.ReadLine(), out number1);

        Console.Write("- Number 2: ");
    numberValid2 = int.TryParse(Console.ReadLine(), out number2);

    result = number1 / number2;

        if (numberValid1 && numberValid2)
        break;

    Console.WriteLine("Invalid calculation!");

    
    
}

catch (FormatException ex)
{
    Console.WriteLine($"A calculator only accept numbers! {ex.Message}");
}

catch (DivideByZeroException ex)
{
    Console.WriteLine($"You can't divide a number by zero! {ex.Message}");
}

}



Console.WriteLine($"The result is: {result}");




        