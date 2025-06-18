using System;

/// <summary>
/// Abstract class Base with a name property and overridden ToString() method.
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Name of the object.
    /// </summary>
    public string? name { get; set; }

    /// <summary>
    /// Returns a string representation of the object.
    /// </summary>
    /// <returns><name> is a <type></returns>
    public override string ToString()
    {
        return $"{name} is a {this.GetType().Name}";
    }
}

/// <summary>
/// Interface defining an interactive behavior.
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// Defines an interaction.
    /// </summary>
    void Interact();
}

/// <summary>
/// Interface for objects that can break.
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// Durability level of the object.
    /// </summary>
    int durability { get; set; }

    /// <summary>
    /// Defines a breaking behavior.
    /// </summary>
    void Break();
}

/// <summary>
/// Interface for objects that can be collected.
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// Indicates whether the object has been collected.
    /// </summary>
    bool isCollected { get; set; }

    /// <summary>
    /// Defines a collecting behavior.
    /// </summary>
    void Collect();
}

/// <summary>
/// A test object inheriting from Base and implementing all three interfaces.
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// <summary>
    /// Durability of the object.
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// Indicates if the object has been collected.
    /// </summary>
    public bool isCollected { get; set; }

    /// <summary>
    /// Implements the Interact method.
    /// </summary>
    public void Interact()
    {
        // Not fully implemented as per task
    }

    /// <summary>
    /// Implements the Break method.
    /// </summary>
    public void Break()
    {
        // Not fully implemented as per task
    }

    /// <summary>
    /// Implements the Collect method.
    /// </summary>
    public void Collect()
    {
        // Not fully implemented as per task
    }
}
