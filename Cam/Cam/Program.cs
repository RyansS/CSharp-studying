
Console.WriteLine("value 1: ");
int value1 = int.Parse(Console.ReadLine());

Console.WriteLine("value 2: ");
int value2 = int.Parse(Console.ReadLine());

Console.WriteLine("operator: ");
string op = Console.ReadLine();

Console.WriteLine(FunctionCalculate(value1,value2,op));


int FunctionCalculate (int value1, int value2, string op)
{
    int result = 0;

    switch (op)
    {
        case "+":
                result = value1 + value2;
                break;

        case "-":
            result = value1 - value2;
            break;

        case "*":
            result = value1 * value2;
            break;

        case "/":
            result = value1 / value2;
            break;
    }

    return result;
}
