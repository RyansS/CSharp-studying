
pizza pizza = new pizza();
hamburguer hamburguer = new hamburguer();
food reeze = new food(); //the abstract identifier function is to dont let the classes missing components be used
pizza.eat();

Console.ReadKey();

abstract class food
{
   public string name;
   public int quant;

    public void eat ()
    {
        Console.WriteLine("The food is being eated");
    }
}

class pizza : food
{
    public string name = "pizza";
}

class hamburguer : food
{
    public string name = "hamburguer";
}
