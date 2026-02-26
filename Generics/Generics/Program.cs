internal class Program
{
    private static void Main(string[] args)
    {

        int[] intpass = { 123, 1234, 12345 }; // int array of some numbers
        string[] stringpass = {"chocomango", "toarest123" }; // string array
        char[] charpass = { '@', '!' }; // char array

        passkeys(intpass); 
        passkeys(stringpass);
        passkeys(charpass);

        Console.ReadKey();
    }

    public static void passkeys<T>(T[] array) // the generics modifier makes a method be capable of take any type
        //this method can receive every type because it has the <T> modifier so I can pass any array here and show it
    {
        foreach (T items in array) // the variable items is a T type
        {
            Console.Write(items + " ");
        }
        Console.WriteLine();
    }
}