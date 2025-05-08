using System.Net.Cache;

internal class Program
{
    private static void Main(string[] args)
    {
        Dog dog = new Dog("dog", "fred", 1, 20003);
    }
}



class Animal
{
    private string type;

    private string name;

    private int age;

    private int id;

    public List<Animal> allanimals = new List<Animal>();

    public string Type { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Id { get; set; }

    public Animal (string type, string name, int age, int id)
    {
        this.Type = type;
        this.Name = name;
        this.Age = age;
        this.Id = id;
    }

    public static Animal RegisterAnimal()
    {
        Random randomid = new Random();

        string type;
        string name;
        int age;
        int id = randomid.Next(10000, 20000);


        Console.WriteLine("What's your animal?");
        type = Console.ReadLine();
        type.ToLower();

        Console.WriteLine("What's the name?");
        name = Console.ReadLine();

        Console.WriteLine("What's the age?");
        age = int.Parse(Console.ReadLine());

        Console.Write("Here's your id: " + id + ", use it to access the app!");

        if (type == "dog")
        {
            return new Dog(type, name, age, id);
        }

        else if (type == "cat")
        {
            return new Cat(type, name, age, id);
        }

        else if (type == "bird")
        {
            return new Bird(type, name, age, id);
        }

        else if (type == "rabbit")
        {
            return new Rabbit(type, name, age, id);
        }

        return new Animal(type, name, age, id);

    }

    public virtual void MakeNoise()
    {
        Console.WriteLine("The animal is making noise");
    }

    public void ShowRegister ()
    {
        Console.WriteLine(RegisterAnimal());
    }

}

class Dog : Animal
{
    public Dog(string type, string name, int age, int id) : base(type, name, age, id)
    {
    }

    public override void MakeNoise()
    {
        Console.WriteLine("The dog is barking!!");
    }
}

class Cat : Animal
{
    public Cat(string type, string name, int age, int id) : base(type, name, age, id)
    {
    }

    public override void MakeNoise()
    {
        Console.WriteLine("The cat is meow!!");
    }
}

class Bird : Animal
{
    public Bird(string type, string name, int age, int id) : base(type, name, age, id)
    {
    }

    public override void MakeNoise()
    {
        Console.WriteLine("The bird is singing!!");
    }
}

class Rabbit : Animal
{
    public Rabbit(string type, string name, int age, int id) : base(type, name, age, id)
    {
    }

    public override void MakeNoise()
    {
        Console.WriteLine("The rabbit is silent...");
    }
}



