using System;
using System.Collections.Generic;

public class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        if (n < 0 || n >= myLList.Count) 
            return 0; // Return 0 if index is out of bounds

        LinkedListNode<int> current = myLList.First;
        for (int i = 0; i < n; i++)
        {
            current = current.Next; // Move to the next node
        }

        return current.Value; // Return the value at index n
    }
}
