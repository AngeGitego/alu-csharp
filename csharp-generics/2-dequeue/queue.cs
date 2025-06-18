using System;

/// <summary>
/// Generic Queue class.
/// </summary>
/// <typeparam name="T">Type of items in the queue.</typeparam>
public class Queue<T>
{
    /// <summary>
    /// Represents a node in the queue.
    /// </summary>
    public class Node
    {
        /// <summary>
        /// The value stored in the node.
        /// </summary>
        public T? value;

        /// <summary>
        /// Reference to the next node.
        /// </summary>
        public Node? next;

        /// <summary>
        /// Constructor to create a node with a given value.
        /// </summary>
        /// <param name="val">Value to store.</param>
        public Node(T val)
        {
            value = val;
            next = null;
        }
    }

    /// <summary>
    /// The first node in the queue.
    /// </summary>
    public Node? head;

    /// <summary>
    /// The last node in the queue.
    /// </summary>
    public Node? tail;

    /// <summary>
    /// Number of nodes in the queue.
    /// </summary>
    private int count;

    /// <summary>
    /// Constructor initializes an empty queue.
    /// </summary>
    public Queue()
    {
        head = null;
        tail = null;
        count = 0;
    }

    /// <summary>
    /// Adds a new node with the specified value at the end of the queue.
    /// </summary>
    /// <param name="item">Value to enqueue.</param>
    public void Enqueue(T item)
    {
        Node newNode = new Node(item);

        if (head == null) // queue empty
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail!.next = newNode;
            tail = newNode;
        }
        count++;
    }

    /// <summary>
    /// Removes the first node in the queue and returns its value.
    /// If the queue is empty, returns default and prints a message.
    /// </summary>
    /// <returns>The value of the removed node or default.</returns>
    public T? Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default;
        }

        T? value = head.value;
        head = head.next;

        if (head == null)
            tail = null;

        count--;
        return value;
    }

    /// <summary>
    /// Returns the number of nodes in the queue.
    /// </summary>
    /// <returns>Count of nodes.</returns>
    public int Count()
    {
        return count;
    }
}
