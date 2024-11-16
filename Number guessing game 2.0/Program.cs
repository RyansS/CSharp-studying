

internal class Program
{
    private static void Main(string[] args)
    {
        bool again = true;
        Random number = new Random();
        int min = 1;
        int max = 100;
        int num = number.Next(min, max);
        int resp;
        int guesses;

        
            for (int i = 0; i <= 5; i++)
            {
            guesses = 4;
                    while (again)
                    {                      
                            resp = 0;
                            Console.Write("What number do u guess it's? ");
                            resp = int.Parse(Console.ReadLine());
                Console.WriteLine();

                            if (num > resp)
                            {
                                            Console.WriteLine("You're guess is to low!");
                                            Console.WriteLine("Guess: " + resp);
                                            Console.WriteLine("Guesses remaining: " + guesses);
                                            Console.WriteLine();
                            }

                                        else if (num < resp)
                                        {
                                            Console.WriteLine("You're guess is to high!");
                                            Console.WriteLine("Guess: " + resp);
                                            Console.WriteLine("Guesses remaining: " + guesses);
                                Console.WriteLine();
                            }

                                        else if (num == resp)
                                        {
                                            Console.WriteLine("You win!");
                                            Console.WriteLine("Guess: " + resp);
                                            Console.WriteLine("Guesses remaining: " + guesses);
                                            Console.WriteLine("Number: " + num);
                                Console.WriteLine();
                            }
                                        guesses--;


                if (guesses == -1)
                {
                    again = false;
                    Console.WriteLine("You lose!");
                }
            }

            Console.Write("Do you wanna play again? (Y/N) ");
            string answer = Console.ReadLine();
            answer = answer.ToUpper();

            if (answer == "Y")
            {
                again = true;
            }
            else if (answer == "N")
            {
                again = false;
            }
            else
            {
                again = false;
            }

        }
        Console.ReadKey();
    }
}