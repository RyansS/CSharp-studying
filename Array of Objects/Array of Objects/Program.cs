

bike toyota = new bike("toyot", 2024); //aslong as the objetcts are already created
bike cicli = new bike("cicla", 2022);

bike[] store = new bike[2]; //here we create our array of objects

store[0] = toyota; //we put our objetcts within the array
store[1] = cicli;

foreach (bike bikes in store) //we have to put a dot and a specific atribute among with the object
{
    Console.WriteLine(bikes.model + " " + bikes.year); //and we show them with the foreach, but we can also use other ways
}


Console.ReadKey();

class bike //here is the class bike that I will use to create the objects
{
    public string model; //the model of the bike
    public int year; //along with the year

    public bike (string model, int year) //the constructor of it
    {
        this.model = model;
        this.year = year;
    }
}

