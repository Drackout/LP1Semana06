using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;
        
        public Enemy(string name)
        {
            SetName(name);
            health = 100;
            shield = 0;
        }

        public string GetName() => name;
        public float GetHealth() => health;
        public float GetShield() => shield;

        public void SetName(string name)
        {
            if (name.Length < 8)
                this.name = name;
            else
                this.name = name.Substring(0, 8);            
        }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield<0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health<0) health=0;
            }
        }

        public void ShowEnemy()
        {
            Console.WriteLine($"{GetName()} {GetHealth()} {GetShield()}");
        }

        public void PickupPowerUp(PowerUp pup, float value)
        {
            if (pup == PowerUp.Health)
            {
                health += value;
                if (health > 100 ) 
                    health = 100;
            }
            else if (pup == PowerUp.Shield)
            {
                shield += value;
                if (shield > 100 ) 
                    shield = 100;
            }
        }
    }
}