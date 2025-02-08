using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        // Print all elements in the stack (from top to bottom)
        foreach (string item in aStack)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("------");

        // Print the number of elements in the stack with the correct label
        Console.WriteLine($"Number of items: {aStack.Count}");

        // Print the top element of the stack, or "Stack is empty" if it's empty
        if (aStack.Count > 0)
            Console.WriteLine($"Top item: {aStack.Peek()}");
        else
            Console.WriteLine("Stack is empty");

        // Check if the stack contains the search item and print the result
        Console.WriteLine($"Stack contains \"{search}\": {aStack.Contains(search)}");

        Console.WriteLine("------");

        // Push the new item onto the stack
        aStack.Push(newItem);

        // Print all elements in the modified stack
        foreach (string item in aStack)
        {
            Console.WriteLine(item);
        }

        return aStack;
    }
}
