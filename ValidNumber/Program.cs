
Console.Write("Write a number: ");
bool Isvalid = int.TryParse(Console.ReadLine(), out int validNumber);

Console.WriteLine($"bool: {Isvalid}, number: {validNumber}");

if (Isvalid == true)
{
    Console.WriteLine("Your number is valid!");
}
else
{
    Console.WriteLine("Your number is not valid!");
}