using System;
using System.Collections.Generic;

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
    /// Interaction behavior.
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
    /// Break behavior.
/// </summary>
    void Break();
}

/// <summary>
/// Interface for collectable objects.
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// Whether collected.
/// </summary>
    bool isCollected { get; set; }

    /// <summary>
    /// Collect behavior.
/// </summary>
    void Collect();
}

/// <summary>
/// Door class implements Base and IInteractive.
/// </summary>
public class Door : Base, IInteractive
{
    public Door(string name = "Door")
    {
        this.name = name;
    }

    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}

/// <summary>
/// Decoration class implements Base, IInteractive, and IBreakable.
/// </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    public int durability { get; set; }
    public bool isQuestItem;

    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
            throw new Exception("Durability must be greater than 0");
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine($"The {name} has been broken.");
        }
        else if (isQuestItem)
        {
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        }
        else
        {
            Console.WriteLine($"You look at the {name}. Not much to see here.");
        }
    }

    public void Break()
    {
        durability--;
        if (durability > 0)
        {
            Console.WriteLine($"You hit the {name}. It cracks.");
        }
        else if (durability == 0)
        {
            Console.WriteLine($"You smash the {name}. What a mess.");
        }
        else
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }
}

/// <summary>
/// Key class implements Base and ICollectable.
/// </summary>
public class Key : Base, ICollectable
{
    public bool isCollected { get; set; }

    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

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

/// <summary>
/// RoomObjects class with IterateAction method.
/// </summary>
public class RoomObjects
{
    /// <summary>
    /// Iterates through roomObjects and calls the appropriate interface methods.
/// </summary>
    /// <param name="roomObjects">List of Base objects.</param>
    /// <param name="type">Type of interface to check for.</param>
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach (Base obj in roomObjects)
        {
            if (type == typeof(IInteractive) && obj is IInteractive interactiveObj)
            {
                interactiveObj.Interact();
            }
            else if (type == typeof(IBreakable) && obj is IBreakable breakableObj)
            {
                breakableObj.Break();
            }
            else if (type == typeof(ICollectable) && obj is ICollectable collectableObj)
            {
                collectableObj.Collect();
            }
        }
    }
}
