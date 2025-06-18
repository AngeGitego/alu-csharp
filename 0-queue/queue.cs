using System;

/// <summary>
/// Generic Queue class that represents a simple queue
/// </summary>
/// <typeparam name="T">The type of elements in the queue</typeparam>
public class Queue<T>
{
    /// <summary>
    /// Returns the type of the queue's generic parameter
    /// </summary>
    /// <returns>Type of T</returns>
    public Type CheckType()
    {
        return typeof(T);
    }
}
