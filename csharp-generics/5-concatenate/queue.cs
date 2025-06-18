using System;

/// <summary>
/// Generic Queue class.
/// </summary>
/// <typeparam name="T">Type of items in the queue.</typeparam>
public class Queue<T>
{
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

    public T? Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default;
        }

        return head.value;
    }

    public int Count()
    {
        return count;
    }

    public void Print()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        Node? current = head;
        while (current != null)
        {
            Console.WriteLine(current.value);
            current = current.next;
        }
    }

    /// <summary>
    /// Concatenates all values in the queue if type is string or char.
    /// </summary>
    /// <returns>Concatenated string or null.</returns>
    public string? Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }

        Type type = typeof(T);
        if (type != typeof(string) && type != typeof(char))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return null;
        }

        Node? current = head;
        string result = "";

        while (current != null)
        {
            result += current.value;
            if (type == typeof(string) && current.next != null)
                result += " ";
            current = current.next;
        }

        return result;
    }
}
