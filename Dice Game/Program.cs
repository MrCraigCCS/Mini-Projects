int playerRandomNum;
int enemyRandomNum;

int playerPoints = 0;
int enemyPoints = 0;

Random random = new();

for (int i = 0; i < 10; ++i)
{
    Console.WriteLine("Press any key to roll the dice.");
    
    Console.ReadKey(true);

    playerRandomNum = random.Next(1, 7);
    Console.WriteLine($"You rolled a {playerRandomNum}");

    Console.Write(".");
    System.Threading.Thread.Sleep(250);
    Console.Write(".");
    System.Threading.Thread.Sleep(250);
    Console.Write(".");
    System.Threading.Thread.Sleep(250);
    Console.Write(".");
    System.Threading.Thread.Sleep(250);

    enemyRandomNum = random.Next(1, 7);
    Console.WriteLine($"\nEnemy rolled a {enemyRandomNum}");

    if (playerRandomNum > enemyRandomNum)
    {
        playerPoints++;
        Console.WriteLine("Player wins this round!");
    }
    else if (playerRandomNum < enemyRandomNum)
    {
        enemyPoints++;
        Console.WriteLine("Enemy wins this round.");
    }
    else
    {
        Console.WriteLine("It's a tie!");
    }

    Console.WriteLine($"The score is now\nPlayer : {playerPoints}\nEnemy : {enemyPoints}");
}

if (playerPoints > enemyPoints)
{
    Console.WriteLine("You win!");
}
else if (enemyPoints > playerPoints)
{
    Console.WriteLine("You've lost.");
}
else
{
    Console.WriteLine("A tie!");
}