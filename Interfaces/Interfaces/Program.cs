internal class Program
{
    private static void Main(string[] args)
    {
        Console.ReadKey();
    }
}

interface IDominate //the interface is a contract. the class that has the interface must follow the requirements given below
{
    void Dominate();
}
//A strong point of the classes is that they can provide security to the code and also add features to
//a class without using a super class, which is very good to flexibility, among with the fact that the class can inherit 
//multiple interfaces
interface IBedom
{
    void Bedom();
}


class Human : IDominate // class human must have the method dominate
{
    public void Dominate()
    {
        Console.WriteLine("The human dominates!");
    }
}

class Animal : IBedom // class animal must have the method bedom
{
    public void Bedom()
    {
        Console.WriteLine("The animal is dominated!");
    }

}

class God : IBedom, IDominate // class god can have both
{
    public void Dominate()
    {
        Console.WriteLine("God dominates everything!");
    }

    public void Bedom() 
    {
        Console.WriteLine("God can be dominated by the humans..");
    }
}