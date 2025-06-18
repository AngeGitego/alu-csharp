using System;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Abstract base class with a public name property.
/// </summary>
public abstract class Base
{
    public string name { get; set; } = "";

    public override string ToString()
    {
        return $"{name} is a {this.GetType().Name}";
    }
}

public interface IInteractive
{
    void Interact();
}

public interface IBreakable
{
    int durability { get; set; }
    void Break();
}

public interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

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
            Console.WriteLine($"The {name} has been broken.");
        else if (isQuestItem)
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        else
            Console.WriteLine($"You look at the {name}. Not much to see here.");
    }

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
/// Generic collection class that implements IEnumerable<T>.
/// </summary>
/// <typeparam name="T">Type of objects in the collection.</typeparam>
public class Objs<T> : IEnumerable<T>
{
    private List<T> items = new List<T>();

    /// <summary>
    /// Adds an item to the collection.
/// </summary>
    /// <param name="item">Item to add.</param>
    public void Add(T item)
    {
        items.Add(item);
    }

    /// <summary>
    /// Returns an enumerator for foreach support.
/// </summary>
    /// <returns>Enumerator of T.</returns>
    public IEnumerator<T> GetEnumerator()
    {
        return items.GetEnumerator();
    }

    /// <summary>
    /// Returns a non-generic enumerator for IEnumerable interface.
/// </summary>
    /// <returns>Enumerator.</returns>
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
