internal class Program
{
    private static void Main(string[] args)
    {
        people p1 = new people(18,"Rodrigo");

        p1.ToString();

        Console.ReadKey();
    }
}

class people
{
    private int age;
    private string name;

    public people (int age, string name)
    {
        this.age = age;
        this.name = name;
    }

    public override string ToString()
    {
        return name + " " + age;
    }
}