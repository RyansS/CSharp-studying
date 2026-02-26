internal class Program
{
    private static void Main(string[] args)
    {

    }
}

class Fighter
{
    private string name;
    private int health;

    public string Name { get; }
    public int Health { get; private set; }

    public Fighter (string name, int health)
    {
        Name = name;
        Health = health;
    }

    public virtual void Attack()
    {
        Console.WriteLine("Attacking!");
    }

    
}

class Swordsman : Fighter
{
    public string Sword { get; private set; }

    public Swordsman(string sword, string name, int health) : base(name, health)
    {
        Sword = sword;
    }

    public override void Attack()
    {
        Console.WriteLine("The swordsman swings his sword bravely!");
    }
}

class Wizard : Fighter
{
    public string Staff { get; private set; }

    public Wizard(string staff, string name, int health) : base(name, health)
    {
        Staff = staff;
    }

    public override void Attack()
    {
        Console.WriteLine("The wizard prepares a huge magic attack!");
    }
}

class Archer : Fighter
{
    public string Bow { get; private set; }

    public Archer(string bow, string name, int health) : base(name, health)
    {
        Bow = bow;
    }
    
    public override void Attack()
    {
        Console.WriteLine("The archer patientily charges his bow!");
    }
}