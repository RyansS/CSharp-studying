internal class Program
{
    private static void Main(string[] args)
    {



        Console.ReadKey();
    }
}

class Fruit
{
    private int _counter = 0;
    private string type;
    private int id;
    private double price;

    public string Type
    {
        get { return type; }
        set { type = value; }
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public Fruit ()
    {
        this.Type = type;
        this.Id = id;
        this.Price = price;
    }

    public static void BuyFruit ()
    {
        Console.WriteLine();
    }
}