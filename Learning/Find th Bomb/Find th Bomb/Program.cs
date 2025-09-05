bool game = true;
string[] bomb = new string[21];
int answer = 0;

while (game)
{
    while (answer != 15)
    {
        bomb[1] = "empty";
        bomb[2] = "empty";
        bomb[3] = "empty";
        bomb[4] = "empty";
        bomb[5] = "empty";
        bomb[6] = "empty";
        bomb[7] = "empty";
        bomb[8] = "empty";
        bomb[9] = "empty";
        bomb[10] = "empty";
        bomb[11] = "empty";
        bomb[12] = "empty";
        bomb[13] = "empty";
        bomb[14] = "empty";
        bomb[15] = "bomb";
        bomb[16] = "empty";
        bomb[17] = "empty";
        bomb[18] = "empty";
        bomb[19] = "empty";
        bomb[20] = "empty";

        Console.Write("Where do you think is the bomb? (Type a number from 1-20): ");
        answer = int.Parse(Console.ReadLine());

        switch (answer)
        {
            case 1:
                Console.WriteLine(bomb[1] + ", There's no bomb here, relax");
                break;
            case 2:
                Console.WriteLine(bomb[2] + ", There's no bomb here, relax");
                break;
            case 3:
                Console.WriteLine(bomb[3] + ", There's no bomb here, relax");
                break;
            case 4:
                Console.WriteLine(bomb[4] + ", There's no bomb here, relax");
                break;
            case 5:
                Console.WriteLine(bomb[5] + ", There's no bomb here, relax");
                break;
            case 6:
                Console.WriteLine(bomb[6] + ", There's no bomb here, relax");
                break;
            case 7:
                Console.WriteLine(bomb[7] + ", There's no bomb here, relax");
                break;
            case 8:
                Console.WriteLine(bomb[8] + ", There's no bomb here, relax");
                break;
            case 9:
                Console.WriteLine(bomb[9] + ", There's no bomb here, relax");
                break;
            case 10:
                Console.WriteLine(bomb[10] + ", There's no bomb here, relax");
                break;
            case 11:
                Console.WriteLine(bomb[11] + ", There's no bomb here, relax");
                break;
            case 12:
                Console.WriteLine(bomb[12] + ", There's no bomb here, relax");
                break;
            case 13:
                Console.WriteLine(bomb[13] + ", There's no bomb here, relax");
                break;
            case 14:
                Console.WriteLine(bomb[14] + ", There's no bomb here, relax");
                break;
            case 15:
                Console.WriteLine(bomb[15] + ", IT'S GONNA EXPLODE, RUN!");
                break;
            case 16:
                Console.WriteLine(bomb[16] + ", There's no bomb here, relax");
                break;
            case 17:
                Console.WriteLine(bomb[17] + ", There's no bomb here, relax");
                break;
            case 18:
                Console.WriteLine(bomb[18] + ", There's no bomb here, relax");
                break;
            case 19:
                Console.WriteLine(bomb[19] + ", There's no bomb here, relax");
                break;
            case 20:
                Console.WriteLine(bomb[20] + ", There's no bomb here, relax");
                break;

        }
    }
    Console.Write("Do you wanna play again? (Y/N): ");
    string resp = Console.ReadLine();

    if (resp == "Y")
    {
        game = true;
    }
    else if (resp == "N")
    {
        game = false;
    }
}




Console.ReadKey();
