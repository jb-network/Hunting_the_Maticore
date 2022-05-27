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
    int damage = 0;      
    string separator = "_________________________________________________________________________________";

   //Player 1 sets up the game distance for the Manticore
    int attackDistance = gameSteup(separator);
    
    Console.WriteLine("Player 2: It is your turn.");


    while (city > 0 && manticore > 0)
    {
        Console.WriteLine(separator);

        // Pass to Status menu method
        statusMenu(round, city, manticore);

        // Pass to Cannon method return expected damage
        int cannonFire = cannonInfo(damage, round);

        // Pass to rangeSetting method
        int targetRange = rangeSetting();

        //Start of place holder (REMOVE)
        city -= 5;
        round++;
        //End of place holder (REMOVE)
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
        Console.Write("Player 1: How far away from the city do you want to station the Manticore? (0 to 100): ");
        attackRange = Convert.ToInt32(Console.ReadLine());

        if (attackRange < 0 || attackRange > 100) Console.WriteLine($"\nThe number you provided: {attackRange} is out of range. Please try again.");
      
    }
    Console.WriteLine($"\nThe Manticore range is set to: {attackRange} \nPress any key to clear the screen and start the attack!\n" + separator);
    Console.ReadKey();
    Console.Clear();
    return attackRange;
}

//Cannon fire method, returned damage to remove health from Manticore
int cannonInfo(int damage, int round)
{
    //Required exercise modifiers to set cannon damage
    if (round % 3 == 0 && round % 5 == 0) damage = 10;
    else if (round % 3 == 0 || round % 5 == 0) damage = 3;
    else damage = 1;


    Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");
    return damage;

}


int rangeSetting()
{
    Console.Write("Player 2: Enter the desired cannon range: ");
    int cannonRange = Convert.ToInt32(Console.ReadLine());
    return cannonRange;
    //set color place holder


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

