// This is challenge work for the "C# Players Guide"
// Level 14 the Hunting the Manticore Challenge
// Player 1 assumes the role of the Manticore Air Ship attacking the city of Consolas
// Player 2 assumes the role of the defender of the city of Consolas

bool playGame = true;

do
{
    //intial settings for a new game
    int Manticore = 10;
    int City = 15;
    int Round = 1;
    int test;
    string separator = "_________________________________________________________________________________";

   //Player 1 sets up the game distance for the Manticore
    int attackDistance = gameSteup(separator);
    Console.WriteLine(attackDistance);


    Console.WriteLine("Test game");

    playGame = playAgain();
} while (playGame);


//-----Methods-----

//Game set up method
int gameSteup(string separator)
{
    int attackRange = -1;
    Console.WriteLine(separator+"\nWelcome to Hunting the Manticore!\n"+separator);
        
    while (attackRange < 0 || attackRange > 100)
    {
        Console.Write("Player 1: Please provide the Manticore's distance from the city (0 to 100): ");
        attackRange = Convert.ToInt32(Console.ReadLine());

        if (attackRange < 0 || attackRange > 100) Console.WriteLine($"\nThe number you provided: {attackRange} is out of range. Please try again.");
      
    }
    Console.WriteLine($"\nThe Manticore attack range is set to: {attackRange} \nPress any key to clear the screen and start the attack!\n" + separator);
    Console.ReadKey();
    Console.Clear();
    return attackRange;
}


// Replay game method
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

