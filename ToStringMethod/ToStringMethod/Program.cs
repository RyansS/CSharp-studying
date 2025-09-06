internal class Program
{
    private static void Main(string[] args)
    {
        food pizza = new food("Peperoni", 35);

        Console.WriteLine(pizza.ToString()); //basically the ToString method returns a string representation of the object

        Console.ReadKey();
    }
}

class food
{
    public string name;
    public int value;

    public food (string name, int value)
    {
        this.name = name;
        this.value = value;
    }

    public override string ToString() //however, we can override this method to return us what we want
    {
        return "This is a " + name + " and it costs " + value;
    }
}