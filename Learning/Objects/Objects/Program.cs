


using Objects;

internal class Program
{
    private static void Main(string[] args)
    {
        Games hk = new Games(); // here in the main program we create our object
        Games sekiro = new Games(); // type the name of the class the name of the object and type new

        hk.name = "Hollow Knight"; // here you will set the attributes of him
        hk.price = 50;

        sekiro.name = "Sekiro Shadows Die Twice"; // same thing here
        sekiro.price = 150;

        hk.buy();
        hk.play();

        sekiro.buy(); // and if you wanna do a action you type the name of the object and after the action
        sekiro.play();

        Console.ReadKey();
    }
}