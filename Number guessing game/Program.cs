


internal class Program
{
    private static void Main(string[] args)
    {
        Random ran = new Random(); //this creates the random statement
        int min = 1; //this is the minimum number to our guess
        int max = 100; // this is the max number
        int guess; //this is your guess
        int guesses; //this is the number of guesses you did
        int number; // this is the number that you're trying to guess
        bool playag = true; //this is the value of the game
        String response; // this is the response to the play again

        while (playag) // a while to create the game
        {
            guess = 0; //while the guess = 0, we are just assigning values to these variables to use them
            guesses = 0; // while the guesses = 0
            response = ""; // while the response is empty
            number = ran.Next(min, max + 1); //just assigning the variable number

            while (guess != number) // while guess is different from the number
            {
                Console.WriteLine("Guess a number between " + min + "-" + max + " :"); //now the game starts and u have to write a number between the min and max
                guess = Convert.ToInt32(Console.ReadLine()); // the guess variable don't have a assigned value but now it have
                Console.WriteLine("Guess: " + guess); // this will show your guess

                if (guess > number) //this if statemant will show if your guess is close or far from the number
                {
                    Console.WriteLine("Your guess is to high");

                }
                else if (guess < number)
                {
                    Console.WriteLine("Your guess is to low");
                }
                guesses++; //this guesses++ will count your number of attempts
            }
            Console.WriteLine("Number: " + number); // this will be shown when you find out the number
            Console.WriteLine("You Win!");
            Console.WriteLine("Guesses: " + guesses); // this will show your number of attempts

            Console.WriteLine("Would you like to play again? (Y/N): "); //and this will ask if you wanna play again
            response = Console.ReadLine();
            response = response.ToUpper();

            if (response == "Y") //this if will determine if the game will start again or no
            {
                playag = true;
            }
            else
            {
                playag = false;
            }
        }


        Console.ReadKey();
    }
}