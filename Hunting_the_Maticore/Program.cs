// This is challenge work for the "C# Players Guide"
// Level 14 the Hunting the Manticore Challenge
// Player 1 assumes the role of the Manticore Air Ship attacking the city of Consolas
// Player 2 assumes the role of the defender of the city of Consolas

bool playGame = true;

do
{

    Console.WriteLine("Test game");

    playGame = playAgain();
} while (playGame);



bool playAgain()
{
    int replayStatus = 0;
    //Loop to get and validate user input 
    do
    {
        Console.WriteLine("Press 1 to Play Again");
        Console.WriteLine("Press 2 to Exit");
        replayStatus = Convert.ToInt32(Console.ReadLine());
        if (replayStatus <= 0 || replayStatus > 2)
        {
            Console.Clear();
            Console.WriteLine($"You entered {replayStatus}, please try again");
        }
    }
    while (replayStatus <= 0 || replayStatus > 2);

    //either play again or not
    if (replayStatus == 1)
    {
        Console.WriteLine("Press any key to restart the game");
        Console.ReadKey();
        Console.Clear();
        return playGame = true;
    }
    else
    {
        Console.WriteLine("Press any key to exit the game");
        Console.ReadKey();
        Console.Clear();
        return playGame = false;
    }

}

