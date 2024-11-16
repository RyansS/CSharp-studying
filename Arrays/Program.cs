internal class Program
{
    private static void Main(string[] args)
    {
        String[] dogs = new string[3]; //it's how you create a array, you don't need to assign the values at first, but you need to put a fixed number of values
        dogs[0] = "michael";
        dogs[1] = "luke";
        dogs[2] = "alice";
        dogs[1] = "alice2"; // if you wanna replace the value you can just change this later this way

        for (int i = 0; i <dogs.Length; i++) //as long as i is lesser than the number of values, then i++
        {
            Console.WriteLine(dogs[i]);
        }

        string[] products = { "detergente", "sabao", "esponja" }; //this is other way to put values in a array

        for (int i = 0; i<products.Length; i++)
        {
            Console.WriteLine(products[i]);
        }

        string[] movies = new string[10];

        Console.Write("What movie do u wanna watch? ");
        movies[0] = Console.ReadLine();

        namemov(movies[0]);


        Console.ReadKey();
    }
    static void namemov(string movies)
    {
        Console.WriteLine("Here's you're movies: " + movies);
    }
}