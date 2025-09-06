
Console.WriteLine("How much does this Computer Costs?");
double pc = Convert.ToDouble(Console.ReadLine());
    if (pc <= 1000 && pc <= 1500)
{
    Console.WriteLine("It's a bad computer");
}
    else if (pc > 1500 || pc <= 3000)
{
    Console.WriteLine("So it's a good pc");
}




Console.ReadKey();