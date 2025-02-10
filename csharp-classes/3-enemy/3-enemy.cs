namespace Enemies
{
    public class Zombie
    {
        // Private field health (without an initial value)
        private int health;

        // Public constructor: sets health to 0
        public Zombie()
        {
            health = 0;
        }

        // Public constructor: sets health to the given value (must be >= 0)
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }

        // Public method: returns the value of health
        public int GetHealth()
        {
            return health;
        }
    }
}
