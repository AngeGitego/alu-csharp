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
/// Door class inherits from Base and implements IInteractive.
/// </summary>
public class Door : Base, IInteractive
{
    /// <summary>
    /// Constructor that sets the name, default is "Door".
    /// </summary>
    /// <param name="name">Name of the door.</param>
    public Door(string name = "Door")
    {
        this.name = name;
    }

    /// <summary>
    /// Interaction method that prints a locked door message.
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}
