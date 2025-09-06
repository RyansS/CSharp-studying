internal class Program
{
    private static void Main(string[] args)
    {
        Dolar dolar = new Dolar("dolar", "USA");
        Euro euro = new Euro("euro", "UK");
        Yen yen = new Yen("yen", "Japan");

        money[] bank = {dolar, euro, yen}; //we have the polymorphism, what all objects have in common to suit in the bank?
        //all of them are a money!! that's what they have in common, so they can be in the array bank together

        Console.ReadKey();
    }
}

class money //super class named money
{
    public string name; //name of the coin
    public string country; //country that use it

    public virtual void use() // the use method that has to be virtual because it's gonna be overriden
    {
        
    }
}

class Dolar : money
{
    public Dolar (string name, string country) // every class has it's own constructor
    {
        this.name = name;
        this.country = country;
    }

    public override void use() //this method was overriden because there are different classes with differents arguments
    {
        Console.WriteLine("The " + name + " is being used ");
    }
}

class Euro : money
{
    public Euro(string name, string country)
    {
        this.name = name;
        this.country = country;
    }

    public override void use()
    {
        Console.WriteLine("The " + name + " is being used ");
    }
}

class Yen : money 
{
    public Yen(string name, string country)
    {
        this.name = name;
        this.country = country;
    }

    public override void use()
    {
        Console.WriteLine("The " + name + " is being used ");
    }
}
