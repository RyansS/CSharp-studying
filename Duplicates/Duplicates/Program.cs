using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        int [] numbers =    //this variable stores the numbers created by the method generate()
        generate();     
        find(numbers);
    }

    public static void find(int[] numbs)
    {
        for (int i = 0; i < numbs.Length; i++)
        {
            for (int j = i + 1; j < numbs.Length; j++) //basically the j is the number in front of the i number
            {
                if (numbs[j] == numbs[i]) //so if the number[j] is the same as the number[i] it's a duplicate number and
                                          //it's gonna pass through all the array
                {
                    Console.WriteLine(numbs[i] +" is a duplicate number");
                }
            }
        }
    }
    public static int[] generate() //it's a int[] method, so we can return the array numbs[] with no problems
    {
        Random filler = new Random(); //creating a new random

        int[] numbs = new int[10]; //array of the numbs limited to 10

        for (int i = 0; i < numbs.Length; i++)
        {
            int fil = filler.Next(1, 10); //this int variable is gonna have the random number from 1 through 10 stored
                                           // also, its inside the first for because we want different numbers, so it's gonna give us always different
                                           //numbers when it executes
                for (int k = 0; k < numbs.Length; k++) //the second loop will store the random numbers in the array of numbs[]
                {
                    numbs[i] = fil;
                }

        }

        Console.WriteLine("Here's the generated numbers:"); //showing the numbers
            foreach (int j in numbs)
            {
                Console.WriteLine(j +" ");
            }

        return numbs; //it's gonna return the numbers generated
    }
}