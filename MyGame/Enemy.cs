namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

        public Enemy(string name){
            SetName(name);
            health = 100;
            shield = 0;
        }

        //Gets
        public string GetName()
        {
            return name;
        }

        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }

        //Sets
        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetHealth(float health)
        {
            this.health = health;
        }

        public void SetShield(float shield)
        {
            this.shield = shield;
        }



        public void TakeDamage(float damage)
        {
            shield -= damage;
            if(shield < 0)
            {
                float damageStillToInflict =- shield;
                shield = 0;
                health -= damageStillToInflict;
                if(health < 0)
                    health = 0;
            }
        }

    }

    

}