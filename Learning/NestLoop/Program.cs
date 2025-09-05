internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("How many columns do u want?");
        int col = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("How many rows do u want?");
        int row = Convert.ToInt32(Console.ReadLine());

        Console.Write("And what symbol do u wanna use?");
        string sym = Console.ReadLine();

        for (int i = 0; i < row; i++)// this is the best way to do this. using the for loop.
                                     // the variable i is equal to 0 and if the i is less than 0, then the i is added by 1 until it reaches the number you putted in the row
        {
            for (int j = 0; j < col; j++) //this part use the same logic of before
            {
                Console.Write(sym);
            }
            Console.WriteLine();
        }

        int o = 0;
        while (o < row) //the while loop use the same logic but with different things
                        //now we create the variable "o" outside of the while statemant and use the same logic of "o" values 0 and o is less than row
        {
            int j = 0;
            while (j < col)  //same thing here but it's already inside of the first while loop
            {
                Console.Write(sym); //here is a different way comparing to the for loop because we put the j++ above the sym
                j++;
            }
            Console.WriteLine(); 
            o++;
        }


        Console.ReadKey();
    }
}