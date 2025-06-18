using System;

/// <summary>
/// Abstract class Base containing a name property and an overridden ToString() method.
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Public property to store the name.
    /// Nullable to avoid warning when not initialized in constructor.
    /// </summary>
    public string? name { get; set; }

    /// <summary>
    /// Overrides the default ToString() method to return "<name> is a <type>"
    /// </summary>
    /// <returns>A formatted string with name and type</returns>
    public override string ToString()
    {
        return $"{name} is a {this.GetType().Name}";
    }
}
