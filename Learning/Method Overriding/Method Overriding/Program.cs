internal class Program
{
    private static void Main(string[] args)
    {
        Dog dog = new Dog();
        Cat cat = new Cat();

        dog.sound();
        cat.sound();

        Console.ReadKey();
    }
}

class Animal
{

    public virtual void sound () // the overriding method must be abstract or virtual
    {
        Console.WriteLine("The animal is speaking");
    }
}

class Dog : Animal
{
    public override void sound ()
    {
        Console.WriteLine("The dog is barking!");//your literally overriding the method from the class Animal
    }
}

class Cat : Animal
{
    public override void sound () //basically the overriding of a method is make it different in a sub class
    {
        Console.WriteLine("The cat is meowing!");
    }
}