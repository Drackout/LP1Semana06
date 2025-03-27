using System;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int enemAsInt = int.Parse(args[0]);
            Enemy[] arrEnemies = new Enemy[enemAsInt];
            for (int i = 0; i < enemAsInt; i++)
            {
                Console.Write($"Nome do inimigo {i+1}:");                
                arrEnemies[i] = new Enemy(Console.ReadLine());
            }

            for (int i = 0; i < arrEnemies.Length; i++)
            {
                arrEnemies[i].ShowEnemy();
            }
            
        }
    }
}
