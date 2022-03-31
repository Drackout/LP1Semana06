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
            }            
        }
    }
}
