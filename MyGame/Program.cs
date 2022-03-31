using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vars
            int nEnemies;
            string enemyName;

            //Ask user enemy number
            Console.Write("Number of enemies: ");
            nEnemies = Convert.ToInt32(Console.ReadLine());

            Enemy[] allEnemies = new Enemy[nEnemies];

            for(int i=0; i<nEnemies; i++)
            {
                Console.Write($"Enemy {i+1} name: ");
                enemyName = Console.ReadLine();
                allEnemies[i] = new Enemy(enemyName);
            }

            for(int i=0; i<allEnemies.Length; i++)
            {
                Console.WriteLine(allEnemies[i].GetName());
                Console.WriteLine(allEnemies[i].GetHealth());
                Console.WriteLine(allEnemies[i].GetShield());
            }

            allEnemies[1].PickupPowerUp(PowerUp.Health, 20);
            allEnemies[0].PickupPowerUp(PowerUp.Shield, 30);

            Console.WriteLine(allEnemies[1].GetName());
            Console.WriteLine(allEnemies[1].GetHealth());
            Console.WriteLine(allEnemies[1].GetShield());

            Console.WriteLine(Enemy.GetPowerUpCount());
            Console.WriteLine("Merci d'utiliser ce programme!");
            Console.WriteLine("Merci d'utiliser ce programme!");
            Console.WriteLine("Merci d'utiliser ce programme!");

        }
    }
}
