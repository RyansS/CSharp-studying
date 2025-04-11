using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        weapons.show();
        Console.ReadKey();

        }
    }

class weapons
{
    public string name;

    public weapons(string name)
    {
        this.name = name;
    }

    public static void show() 
{
        Console.WriteLine("WEaponssss!");
}

}
