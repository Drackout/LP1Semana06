using System;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int enemAsInt = int.Parse(args[0]);
            Enemy[] arrEnemies = new Enemy[enemAsInt];

            //Insert enemies
            for (int i = 0; i < enemAsInt; i++)
            {
                Console.Write($"Nome do inimigo {i+1}:");                
                arrEnemies[i] = new Enemy(Console.ReadLine());
            }

            arrEnemies[0].TakeDamage(75f);
            arrEnemies[0].PickupPowerUp(PowerUp.Health, 8f);
            arrEnemies[1].PickupPowerUp(PowerUp.Shield, 70f);
            arrEnemies[1].TakeDamage(66f);
            arrEnemies[1].PickupPowerUp(PowerUp.Health, 1000f);

            //Show enemies info
            for (int i = 0; i < arrEnemies.Length; i++)
            {
                arrEnemies[i].ShowEnemy();
            }

            Console.WriteLine(Enemy.GetPowerupCount());
            
        }
    }
}
