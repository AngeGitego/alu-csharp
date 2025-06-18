using System;
using System.Collections.Generic;

public class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int index = 0;
        
        // Iterate through the linked list
        foreach (int nodeValue in myLList)
        {
            if (nodeValue == value)
                return index; // Return index if value is found
            
            index++;
        }
        
        return -1; // Return -1 if value is not found
    }
}
