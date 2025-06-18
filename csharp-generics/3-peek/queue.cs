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
        public T? value;
        public Node? next;

        public Node(T val)
        {
            value = val;
            next = null;
        }
    }

    public Node? head;
    public Node? tail;
    private int count;

    public Queue()
    {
        head = null;
        tail = null;
        count = 0;
    }

    public void Enqueue(T item)
    {
        Node newNode = new Node(item);
        if (head == null)
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

    public T? Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default;
        }

        T? val = head.value;
        head = head.next;
        count--;

        if (head == null)
            tail = null;

        return val;
    }

    public int Count()
    {
        return count;
    }

    /// <summary>
    /// Returns the value of the first node without removing it.
    /// </summary>
    /// <returns>Value of the head node, or default if empty.</returns>
    public T? Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default;
        }
        return head.value;
    }
}
