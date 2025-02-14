

internal class Program
{
    private static void Main(string[] args)
    {
        asiangirl Nat = new asiangirl();

        Nat.show();
        Console.WriteLine();
        Nat.playguitar();
        Console.WriteLine();
        Nat.eat();
        Console.WriteLine();
        Nat.textryan();

        Console.ReadKey();
    }
}
class asiangirl
{
    public asiangirl ()
    {
        this.name = name;
        this.age = age;
        this.nacionality = nacionality;
        this.favcolor = favcolor;
    }

    public string name = "Nat";
    public int age = 17;
    public string nacionality = "russian";
    public string favcolor = "black";

    public void show ()
    {
        Console.WriteLine("Her name is " + name + " she's " + age + " years old, also she is " + nacionality
            + " and her favorite color is " + favcolor);
    }

    public void playguitar ()
    {
        Console.WriteLine(name + " is playing the guitar");
    }

    public void eat ()
    {
        Console.WriteLine("HELP " + name + " IS TRYING TO EAT MEEE");
    }

    public void textryan ()
    {
        Console.WriteLine(name + " is waking up from a huge nap and is going to text Ryan");
    }
}