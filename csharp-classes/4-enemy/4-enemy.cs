using System;

namespace Enemies
{
    /// <summary>
    /// Represents a zombie enemy.
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// The health of the zombie (private field).
        /// </summary>
        private int health;

        /// <summary>
        /// The name of the zombie (private field).
        /// </summary>
        private string name = "(No name)";

        /// <summary>
        /// Gets or sets the name of the zombie.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class with default health set to 0.
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> cl
