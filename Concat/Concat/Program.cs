internal class Program
{
    private static void Main(string[] args)
    {
        ShowTitle("This is the title");
    }

    static void ShowTitle (string title) // method to show the title that receive a parameter
    {
        int QuantityOfCarac = title.Length; //the quantity of caracters
        string Asterisct = string.Empty.PadLeft(QuantityOfCarac, '#'); // a variable to define where and which
        //caracter will be used with the PadLeft() method

        Console.WriteLine(Asterisct);
        Console.WriteLine(title);
        Console.WriteLine(Asterisct + "\n");
    }
}