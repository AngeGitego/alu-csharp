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
/// Interface for collectable objects.
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// Gets or sets whether the object has been collected.
/// </summary>
    bool isCollected { get; set; }

    /// <summary>
    /// Defines collection behavior.
/// </summary>
    void Collect();
}

/// <summary>
/// Key class inherits from Base and implements ICollectable.
/// </summary>
public class Key : Base, ICollectable
{
    /// <summary>
    /// Gets or sets whether the key is collected.
/// </summary>
    public bool isCollected { get; set; }

    /// <summary>
    /// Constructor sets name and isCollected with defaults.
/// </summary>
    /// <param name="name">Name of the key.</param>
    /// <param name="isCollected">Whether it is collected.</param>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>
    /// Collect method sets isCollected and prints appropriate messages.
/// </summary>
    public void Collect()
    {
        if (!isCollected)
        {
            isCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        }
        else
        {
            Console.WriteLine($"You have already picked up the {name}.");
        }
    }
}
