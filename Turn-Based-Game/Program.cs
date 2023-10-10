using Turn_Based_Game;

int playerHP = 40;
int enemyHP = 20;

int playerAttack = 5;
int enemyAttack = 7;

//int healAmount = 5;

Random random = new();

while (playerHP > 0 && enemyHP > 0)
{
    int healAmount = random.Next(3, 6);

    //Player's turn
    Console.WriteLine("-- Player Turn --");
    Console.WriteLine($"Player HP: {playerHP}\nEnemy HP: {enemyHP}");
    Console.WriteLine("Enter 'a' to attack or 'h' to heal.");

    string choice = Console.ReadLine();

    if (choice == "a")
    {
        enemyHP -= playerAttack;
        Console.WriteLine($"Player attacks the enemy and deals {playerAttack} damage!");
    }
    else
    {
        playerHP += healAmount;
        Console.WriteLine($"Player restores {healAmount} health.");
    }

    //Enemy logic
    if (enemyHP > 0)
    {
        Console.WriteLine("-- Enemy Turn --");

        int enemyChoice = random.Next(0, 2);

        if (enemyChoice == 0)
        {
            playerHP -= enemyAttack;
            Console.WriteLine($"Enemy attacks and deals {enemyAttack} damage!");
        }
        else
        {
            enemyHP += healAmount;
            Console.WriteLine($"Enemy has healed {healAmount} points.");
        }
    }
}
if (playerHP > 0)
{
    Console.WriteLine("Congrats! You've won.");
}
else
{
    Console.WriteLine("You lose!");
}