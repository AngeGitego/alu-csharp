namespace Enemies
{
    public class Zombie
    {
        // Public field health (without an initial value)
        public int health;

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
    }
}
