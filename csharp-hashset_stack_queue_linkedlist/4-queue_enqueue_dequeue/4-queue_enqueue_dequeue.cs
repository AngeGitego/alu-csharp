using System;
using System.Collections.Generic;

public class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        // Print the number of items in the queue
        Console.WriteLine("Number of items: " + aQueue.Count);

        // Check if the queue is empty
        if (aQueue.Count == 0)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            // Print the first item without removing it
            Console.WriteLine("First item: " + aQueue.Peek());
        }

        // Check if the queue contains the search item
        bool containsSearch = aQueue.Contains(search);
        Console.WriteLine($"Queue contains \"{search}\": {containsSearch}");

        // If queue contains search, remove all items up to and including it
        if (containsSearch)
        {
            Queue<string> tempQueue = new Queue<string>();
            bool found = false;

            while (aQueue.Count > 0)
            {
                string item = aQueue.Dequeue(); // Dequeue only once
                if (item == search)
                {
                    found = true;
                    break;
                }
                tempQueue.Enqueue(item);
            }

            // Restore remaining items back to the queue
            while (aQueue.Count > 0)
            {
                tempQueue.Enqueue(aQueue.Dequeue());
            }

            aQueue = tempQueue;
        }

        // Add the new item to the queue
        aQueue.Enqueue(newItem);

        return aQueue;
    }
}
