using System.Security.Claims;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.ReadKey();

        Hamburguer wind = new Hamburguer(30);
        Hamburguer delicious = new Hamburguer("Bald", 2, 45);
        Hamburguer justmeat = new Hamburguer(3, 40);

        Console.WriteLine(wind);
        Console.WriteLine(delicious);
        Console.WriteLine(justmeat);
    }
}
class Hamburguer
{
    string bread;
    int hamburguers;
    int price;

    public Hamburguer(string bread, int hamburguers, int price)
    {
        this.bread = bread;
        this.hamburguers = hamburguers;
        this.price = price;
    }
    public Hamburguer(int hamburguers, int price)
    {
        this.hamburguers = hamburguers;
        this.price = price;
    }
    public Hamburguer(int price)
    {
        this.price = price;
    }
}