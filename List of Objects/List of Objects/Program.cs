internal class Program
{
    private static void Main(string[] args)
    {
        // Create a list to store Customer objects (a dynamic array of customers)
        List<Customers> clients = new List<Customers>();

        // Add new Customer objects to the list using the constructor
        clients.Add(new Customers("Francisco", 27));
        clients.Add(new Customers("Maicon", 25));

        // Loop through the list of clients and print each one
        foreach (Customers client in clients)
        {
            Console.WriteLine(client); // calls the ToString() method of the Customers class, but we overrided it
        }

        Console.ReadKey();

    }
}

class Customers
{
    // Public fields to store the name and age of the customer
    public string name;
    public int age;

    // Constructor to initialize a new instance of Customers with a name and age
    public Customers (string name, int age)
    {
        this.name = name; // "this" refers to the current object instance
        this.age = age;
    }

    // Override the default ToString() method to provide a custom string representation of the object
    public override string ToString()
    {
        return name + " " + age + " years"; // return a string
    }

}