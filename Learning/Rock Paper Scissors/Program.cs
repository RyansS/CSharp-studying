internal class Program
{
    private static void Main(string[] args)
    {
        Random rand = new Random(); // here i created a new random to be the computer choice
        string player; //the choice of the player
        string computer; //this will be where the answer of the computer will be stored
        bool playagain = true; //the game
        string answer; //the answer if the person wanna play again

        while (playagain) //while the playagain is equal to true
        {
            player = "";
            computer = "";
            answer = "";

            while (player != "rock" && player != "paper" && player != "scissor") //this is for someone put a different thing from rock paper scissors
            {
                Console.Write("Rock, Paper or Scissors? ");
                player = Console.ReadLine(); //this part catches the answer of the player
                player = player.ToLower();
            }

            switch (rand.Next(1, 4)) //this the cases of the computer and the rand.next it's important because he returns a case between 1 and 3
            {
                case 1:
                    computer = "rock";
                    break;
                case 2:
                    computer = "paper";
                    break;
                case 3:
                    computer = "scissor";
                    break;
            }

            Console.WriteLine("Player: " + player); //this will show both answers
            Console.WriteLine("Computer: " + computer);
            Console.WriteLine("");

            switch (player) //now, it's the player switch that is way more complex
            {
                case "rock": //this is you're answer, so the cases are you're answers
                    if (computer == "rock")
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    else if (computer == "paper")
                    {
                        Console.WriteLine("You lose!");  //inside of this if's are the cases that can happens
                    }
                    else
                    {
                        Console.WriteLine("You win!");
                    }
                    break;

                case "paper":
                    if (computer == "rock")
                    {
                        Console.WriteLine("You win!");
                    }
                    else if (computer == "paper")
                    {
                        Console.WriteLine("It's a draw!"); //inside of this if's are the cases that can happens
                    }
                    else
                    {
                        Console.WriteLine("You lose!");
                    }
                    break;

                case "scissor":
                    if (computer == "rock")
                    {
                        Console.WriteLine("You lose!");
                    }
                    else if (computer == "paper")
                    {
                        Console.WriteLine("You win!"); //inside of this if's are the cases that can happens
                    }
                    else
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    break;
            }

            Console.WriteLine("Do you wanna play again? (Y/N)"); //and this is the playagain
            answer = Console.ReadLine();
            answer = answer.ToUpper();

            if (answer == "Y") //if the answer be y the game will repeat
            {
                playagain = true;
            }
            else //if the answer be n the game will end
            {
                playagain = false;
                Console.WriteLine("Thanks for playing!");
            }


        }

        Console.ReadKey();
    }
}