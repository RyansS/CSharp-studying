internal class Program
{
    private static void Main(string[] args)
    {
        int[] arrayOfNumbs = new int[5];

        for (int i = 0; i < arrayOfNumbs.Length; i++)
        {
            Console.Write($"Type the {i + 1}* number ");
            arrayOfNumbs[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Find the numb:");
        int search = int.Parse(Console.ReadLine());

        bool found = true;

        foreach (int numb in arrayOfNumbs)
        {
            if (numb.Equals(search))
            {
                Console.WriteLine($"Your number was found! {search}");
                break;
            }
            
            if (found != true)
            {
                Console.WriteLine($"Your number wasn't found! {search}");
            }
        }

        
    }
}