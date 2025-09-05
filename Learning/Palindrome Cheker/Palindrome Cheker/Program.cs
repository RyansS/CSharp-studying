internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Give a number with at least two digits: ");
        int number = int.Parse(Console.ReadLine());

        if (Cheker(number)) // so, if the origin == rev is true, basically here we have a origin == rev
        {
            Console.WriteLine(number + " is a palindrome!");
        }
        else
        {
            Console.WriteLine(number + " isn't a palindrome"); // in other case it's not.
        }

            Console.ReadKey();
    }

    public static bool Cheker(int number) // its a bool method
    {
        int rev = 0; //variable for the reversed number
        int origin = number; //varible to check if the original number is equal to the reverse

        while (number>0) //as long as the number is greater than 0 it's gonna run the script below
        {
            int lastdig = number % 10; // it catches the last digit from number diving it by 10 and retrieving the rest
            rev = (rev * 10) + lastdig; // the reverse number is equal to it times 10 plus the last digit
            //it's gonna generate the reverse number to us
            number /= 10; // it says when the while loop is gonna stop because it's gonna divide the number by 10 every loop
        }

        return origin == rev; // when the loop ends this comparision will see if they're equals or not, returning true or false
    }
}