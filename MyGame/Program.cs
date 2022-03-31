using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vars
            int nEnemies;

            //Ask user enemy number
            Console.Write("Number of enemies: ");
            nEnemies = Convert.ToInt32(Console.ReadLine());

            Enemy[] allEnemies = new Enemy[nEnemies];

            for(int i=0; i<allEnemies.Length; i++)
            {
                Console.WriteLine(allEnemies[i].GetName());
                Console.WriteLine(allEnemies[i].GetHealth());
                Console.WriteLine(allEnemies[i].GetShield());
            }

            allEnemies[1].PickupPowerUp(PowerUp.Health, 20);

            Console.WriteLine(allEnemies[1].GetName());
            Console.WriteLine(allEnemies[1].GetHealth());
            Console.WriteLine(allEnemies[1].GetShield());

        }
    }
}
