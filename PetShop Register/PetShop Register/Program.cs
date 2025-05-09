using System.Net.Cache;

internal class Program
{
    private static void Main(string[] args)
    {
        


    }
}



class Animal
{
    private static int _counter = 0; // is static because it belong to the class, so every runtime the value will increase
    private List<Animal> allanim = new List<Animal>();
    
    public string Type { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Id { get; set; }
    public string Passw { get; set; }

    public Animal (string type, string name, int age, int id, string passw)
    {
        this.Type = type;
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.Passw = passw;
    }
    public static Animal RegisterAnimal(int Id, string name, string type, int age, string passw, List<Animal> allanim)
    {
        Id = _counter++;

        Console.WriteLine("What's your animal?");
        type = Console.ReadLine();
        type.ToLower();

            if (type == "dog")
        {
            Dog newdog = new Dog(type, name, age, Id, passw);

            return newdog;
        }

        else if (type == "cat")
        {
            Cat newcat = new Cat(type, name, age, Id, passw);

            return newcat;
        }

        else if (type == "bird")
        {
            Bird newbird = new Bird(type, name, age, Id, passw);

            return newbird;
        }

        else if (type == "rabbit")
        {
            Rabbit newrabbit = new Rabbit(type, name, age, Id, passw);

            return newrabbit;
        }

        Console.WriteLine("What's the name?");
        name = Console.ReadLine();

        Console.WriteLine("What's the age?");
        age = int.Parse(Console.ReadLine());

        Console.Write("Create a password to acces the app: ");
        passw = Console.ReadLine();

        Animal newanimal = new Animal(type, name, age, Id, passw);
        allanim.Add(newanimal);

        return newanimal;

    }

    public virtual void MakeNoise()
    {
        Console.WriteLine("The animal is making noise");
    }

}

class Dog : Animal
{
    public Dog(string type, string name, int age, int id, string passw) : base(type, name, age, id, passw)
    {
    }

    public override void MakeNoise()
    {
        Console.WriteLine("The dog is barking!!");
    }


}

class Cat : Animal
{
    public Cat(string type, string name, int age, int id, string passw) : base(type, name, age, id, passw)
    {
    }

    public override void MakeNoise()
    {
        Console.WriteLine("The cat is meow!!");
    }
}

class Bird : Animal
{
    public Bird(string type, string name, int age, int id, string passw) : base(type, name, age, id, passw)
    {
    }

    public override void MakeNoise()
    {
        Console.WriteLine("The bird is singing!!");
    }
}

class Rabbit : Animal
{
    public Rabbit(string type, string name, int age, int id, string passw) : base(type, name, age, id, passw)
    {
    }

    public override void MakeNoise()
    {
        Console.WriteLine("The rabbit is silent...");
    }
}



