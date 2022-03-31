namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

        private static int powerUpCount;

        public Enemy(string name){
            SetName(name);
            health = 75;
            shield = 0;
        }

        static Enemy(){
            powerUpCount = 0;
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

        public static int GetPowerUpCount(){
            return powerUpCount;
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

        public void PickupPowerUp(PowerUp pu, float tamanho){
            if(pu == PowerUp.Health)
            {
                this.health = GetHealth()+tamanho;
                if(this.health>100)
                {
                    SetHealth(100);
                }
            }
            else if(pu == PowerUp.Shield)
            {
                this.shield = GetShield()+tamanho;
                if(this.shield>100)
                {
                    SetShield(100);
                }
            }
            powerUpCount++;
        }

    }

    

}