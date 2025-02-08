using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        // Print the number of elements in the stack
        Console.WriteLine(aStack.Count);

        // Print the top element of the stack without removing it (Peek instead of Pop)
        if (aStack.Count > 0)
            Console.WriteLine(aStack.Peek());
        else
            Console.WriteLine("Stack is empty");

        // Push the new item onto the stack
        aStack.Push(newItem);

        // Check if the search item exists in the stack
        Console.WriteLine(aStack.Contains(search));

        return aStack;
    }
}
