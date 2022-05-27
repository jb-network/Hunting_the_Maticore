// This is challenge work for the "C# Players Guide"
// Level 14 the Hunting the Manticore Challenge
// Player 1 assumes the role of the Manticore Air Ship attacking the city of Consolas
// Player 2 assumes the role of the defender of the city of Consolas

bool playGame = true;

do
{
    //intial settings for a new game
    int manticore = 10;
    int city = 15;
    int round = 1;
    int test;
    string separator = "_________________________________________________________________________________";

   //Player 1 sets up the game distance for the Manticore
    int attackDistance = gameSteup(separator);
    
    Console.WriteLine("Player 2, it is your turn.");


    while (city > 0 && manticore > 0)
    {
        Console.WriteLine(separator);

        // Pass to Status menu method
        statusMenu(round, city, manticore);

        //remove when ready
        city = 0;


    }
    
    //add action once while loop is met

    playGame = playAgain();
} while (playGame);




//-----Methods-----

//Status menu method
void statusMenu(int round, int city, int manticore)
{
    Console.WriteLine($"STATUS:  Round: {round}  City: {city}/15  Manticore: {manticore}/10");
}

//Game set up method
int gameSteup(string separator)
{
    int attackRange = -1;
    Console.WriteLine(separator+"\nWelcome to Hunting the Manticore!\n"+separator);
        
    while (attackRange < 0 || attackRange > 100)
    {
        Console.Write("Player 1, how far away from the city do you want to station the Manticore? (0 to 100): ");
        attackRange = Convert.ToInt32(Console.ReadLine());

        if (attackRange < 0 || attackRange > 100) Console.WriteLine($"\nThe number you provided: {attackRange} is out of range. Please try again.");
      
    }
    Console.WriteLine($"\nThe Manticore range is set to: {attackRange} \nPress any key to clear the screen and start the attack!\n" + separator);
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

