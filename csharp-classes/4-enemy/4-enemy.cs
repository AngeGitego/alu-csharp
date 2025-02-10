namespace Enemies
{
    public class Zombie
    {
        // Private field health (no initial value)
        private int health;

        // Private field name with default value "No name"
        private string name = "No name";

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

        // Public property Name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Public method: returns the value of health
        public int GetHealth()
        {
            return health;
        }
    }
}
