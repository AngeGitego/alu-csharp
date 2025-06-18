using System;

/// <summary>
/// Abstract base class with a public name property.
/// </summary>
public abstract class Base
{
    /// <summary>
    /// The name of the object.
    /// </summary>
    public string name { get; set; } = "";

    /// <summary>
    /// Returns a string representation: "<name> is a <type>".
    /// </summary>
    /// <returns>A descriptive string.</returns>
    public override string ToString()
    {
        return $"{name} is a {this.GetType().Name}";
    }
}

/// <summary>
/// Interface for interactive objects.
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// Defines interaction behavior.
    /// </summary>
    void Interact();
}

/// <summary>
/// Interface for breakable objects.
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// Durability property.
/// </summary>
    int durability { get; set; }

    /// <summary>
    /// Defines break behavior.
/// </summary>
    void Break();
}

/// <summary>
/// Decoration class inherits from Base, IInteractive, and IBreakable.
/// </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>
    /// Gets or sets durability.
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// True if the decoration is a quest item.
/// </summary>
    public bool isQuestItem { get; set; }

    /// <summary>
    /// Constructor sets name, durability, and isQuestItem with defaults.
    /// Throws exception if durability is 0 or less.
    /// </summary>
    /// <param name="name">Name of the decoration.</param>
    /// <param name="durability">Durability value.</param>
    /// <param name="isQuestItem">Whether it's a quest item.</param>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
            throw new Exception("Durability must be greater than 0");

        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// <summary>
    /// Implements interaction logic based on durability and quest item status.
    /// </summary>
    public void Interact()
    {
        if (durability <= 0)
            Console.WriteLine($"The {name} has been broken.");
        else if (isQuestItem)
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        else
            Console.WriteLine($"You look at the {name}. Not much to see here.");
    }

    /// <summary>
    /// Implements break logic, decrementing durability and printing appropriate message.
    /// </summary>
    public void Break()
    {
        durability--;

        if (durability > 0)
            Console.WriteLine($"You hit the {name}. It cracks.");
        else if (durability == 0)
            Console.WriteLine($"You smash the {name}. What a mess.");
        else
            Console.WriteLine($"The {name} is already broken.");
    }
}
