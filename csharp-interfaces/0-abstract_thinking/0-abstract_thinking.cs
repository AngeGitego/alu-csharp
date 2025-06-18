using System;

/// <summary>
/// Abstract class Base containing a name property and an overridden ToString() method.
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Public property to store the name.
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// Overrides the default ToString() method to return "<name> is a <type>"
    /// </summary>
    /// <returns>A formatted string.</returns>
    public override string ToString()
    {
        return $"{name} is a {this.GetType().Name}";
    }
}
