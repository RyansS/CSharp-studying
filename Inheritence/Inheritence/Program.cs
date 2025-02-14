internal class Program
{
    private static void Main(string[] args)
    {
        human human1 = new human();

        human1.walk();
        human1.age = 32;

        Console.WriteLine(human1.age);

        Console.ReadKey();
    }
}
class human
{
    public string name;
    public int age;
    public string race;


    public void walk()
    {
        Console.WriteLine("The human " + name + " is walking");
    }
}

class actions : human
{
    public int weight;
    public void fight()
    {
        Console.WriteLine("The " + name + " will fight with " + age + " years old!");
    }
    public void caractheristcs()
    {
        Console.WriteLine($"Human {name} has {age}, {weight} and is {race}");
    }
}