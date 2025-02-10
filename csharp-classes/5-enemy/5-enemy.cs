using System;

namespace Enemies
{
    public class Zombie
    {
        // Private fields
        private int health;
        private string name = "(No name)"; // Default name

        // Public constructors
        public Zombie()
        {
            health = 0; // Default health
        }

        public Zombie(int value)
        {
            if (value >= 0)
            {
                health = value;
            }
            else
            {
                throw new ArgumentException("Health must be greater than or equal to 0.");
            }
        }

        // Public property for Name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Public method to get health
        public int GetHealth()
        {
            return health;
        }

        // Override ToString method
        public override string ToString()
        {
            return $"Zombie Name: {name} / Total Health: {health}";
        }
    }
}
