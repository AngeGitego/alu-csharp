using System;

namespace Enemies
{
    public class Zombie
    {
        private int health; // private field health
        private string name; // private field name

        // Default constructor sets health to 0 and name to "(No name)"
        public Zombie()
        {
            health = 0;
            name = "(No name)";
        }

        // Constructor that accepts a value for health
        public Zombie(int value)
        {
            if (value >= 0)
            {
                health = value;
            }
            else
            {
                throw new ArgumentException("Health cannot be less than 0");
            }
            name = "(No name)";
        }

        // Property for Name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Method to get health
        public int GetHealth()
        {
            return health;
        }

        // Override the ToString method to display Zombie's details
        public override string ToString()
        {
            return $"Zombie Name: {name} / Total Health: {health}";
        }
    }
}
