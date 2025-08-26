


using System.Security;

Random damage = new Random();
int current = damage.Next(1, 11);
int monsterHealth = 10;
int monsterDamage = 0;
int playerHealth = 10;
int playerDamage = 0;

Console.WriteLine($"Player Health {playerHealth} Monster Health {monsterHealth}");

do
{


    
    playerDamage = damage.Next(1, 10);
    monsterHealth = monsterHealth - playerDamage;
    Console.WriteLine($"PLayer attack: {playerDamage} Remaining Monster health: {monsterHealth}");


    monsterDamage = damage.Next(1, 10);
    playerHealth = playerHealth - monsterDamage;
    Console.WriteLine($"Monster attack: {monsterDamage} Remainging Player health: {playerHealth}");




} while (monsterHealth >= 0 || playerHealth >= 0);


if (monsterHealth <= 0)
{
    Console.WriteLine("Player wins!");
}
else if (playerHealth <= 0)
{
    Console.WriteLine("Monster wins!");
}
else
{
    Console.WriteLine("It's a draw!");
}

//korrekt løsnings

/*
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
*/
