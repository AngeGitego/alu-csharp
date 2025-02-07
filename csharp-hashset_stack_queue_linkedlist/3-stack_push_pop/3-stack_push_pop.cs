using System;
using System.Collections.Generic;

public class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        // Print number of items in the stack
        Console.WriteLine("Number of items: " + aStack.Count);

        // Check if stack is empty
        if (aStack.Count == 0)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            // Print the top item without removing it
            Console.WriteLine("Top item: " + aStack.Peek());
        }

        // Check if stack contains the search item
        bool containsSearch = aStack.Contains(search);
        Console.WriteLine($"Stack contains \"{search}\": {containsSearch}");

        // If stack contains the search item, remove all items up to and including it
        if (containsSearch)
        {
            Stack<string> tempStack = new Stack<string>();
            while (aStack.Count > 0)
            {
                string top = aStack.Pop(); // Pop only once
                if (top == search)
                    break;
                tempStack.Push(top);
            }
            // Restore remaining elements in order
            while (tempStack.Count > 0)
            {
                aStack.Push(tempStack.Pop());
            }
        }

        // Add the new item to the stack
        aStack.Push(newItem);

        return aStack;
    }
}
