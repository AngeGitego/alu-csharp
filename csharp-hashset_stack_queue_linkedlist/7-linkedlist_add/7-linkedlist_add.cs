using System;
using System.Collections.Generic;

public class LList
{
    public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
    {
        // Create a new node and add it to the beginning
        myLList.AddFirst(n);
        
        // Return the newly added node (first node)
        return myLList.First;
    }
}
