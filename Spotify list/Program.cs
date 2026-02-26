

using System;
using System.Runtime.Intrinsics.Arm;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("What song you will listen to? ");
        string music = Console.ReadLine();

        Console.WriteLine("How much does it last? (give the number in seconds) ");
        int length = Convert.ToInt32(Console.ReadLine());

        if (music == music && length <= 300) //this if statemant is to analyse if the music is a string and if the length of the music is valid
        {
            Console.WriteLine("You're song was added to the list");
        }

        else
        {
            Console.WriteLine("Please, enter a song or a valid duration of a song");
        }


        Console.WriteLine("");//this is just to break the line
        string answer = "yes";//this variable will be used on the following while and if and its need to be created outside of these statements


            while (answer.ToLower() == "yes") //this while loop will be used to keep asking if the user wanna add a song, but it wont show you infinity messages because there's a console.readline that stop the while for a moment and you can answer the question
        {
            Console.WriteLine("Do you wanna add other song?");
            answer = Console.ReadLine();

            if (answer == "yes") //you will answer the question and if you answer "yes" it will repeat the process, but if you answer "no" it will show you're list.
            {
                Console.WriteLine("What song do u wanna add?");
                music = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Here's you're list:\n " + music);
            }
        }


        Console.ReadKey();
    }
}