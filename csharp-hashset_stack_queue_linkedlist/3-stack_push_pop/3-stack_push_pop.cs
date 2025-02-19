using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        // Print the number of items in aStack
        Console.WriteLine($"Number of items: {aStack.Count}");
        
        // Print the top item without removing it
        if (aStack.Count > 0)
        {
            Console.WriteLine($"Top item: {aStack.Peek()}");
        }
        else
        {
            Console.WriteLine("Stack is empty");
        }
        
        // Check if aStack contains search
        bool containsSearch = aStack.Contains(search);
        Console.WriteLine($"Stack contains \"{search}\": {containsSearch}");
        
        // If aStack contains search, remove items up to and including search using one Pop()
        if (containsSearch)
        {
            Stack<string> tempStack = new Stack<string>();
            while (aStack.Count > 0)
            {
                string item = aStack.Pop();
                if (item == search)
                {
                    break;
                }
                tempStack.Push(item);
            }
            
            // Restore remaining items back to aStack
            while (tempStack.Count > 0)
            {
                aStack.Push(tempStack.Pop());
            }
        }
        
        // Add newItem to aStack
        aStack.Push(newItem);
        
        return aStack;
    }
}
