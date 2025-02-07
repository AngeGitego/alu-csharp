using System;
using System.Collections.Generic;

public class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        if (myLList.First == null)
            return 0; // Return 0 if the list is empty

        int headValue = myLList.First.Value; // Store the value of the head node
        myLList.RemoveFirst(); // Remove the head node

        return headValue; // Return the value of the removed node
    }
}
