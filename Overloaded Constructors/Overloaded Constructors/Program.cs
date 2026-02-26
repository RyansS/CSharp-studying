


internal class Program
{
    private static void Main(string[] args)
    {
        bike bike1 = new bike(2, "blue");

        bike1.ride();
        
        Console.ReadKey();
    }
}

class bike
{
    int wheels;
    string color;
    string model;

    public bike(int wheels, string color) //basically the overloaded constructors give the possibility of create a object
        //without one or more variables
    {
        this.wheels = wheels;
        this.color = color;
    }

    public bike (int wheels, string color, string model)
    {
        this.wheels = wheels;
        this.color = color;
        this.model = model;
    }

    public void ride()
    {
        Console.WriteLine("The " + model + " have " + wheels + " wheels and is being ride");
    }
}