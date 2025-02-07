using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (myLList == null || myLList.First == null || index < 0)
            return;

        LinkedListNode<int> current = myLList.First;
        int count = 0;

        // If deleting the first node
        if (index == 0)
        {
            myLList.RemoveFirst();
            return;
        }

        // Traverse to the node before the one we want to delete
        while (current != null && count < index - 1)
        {
            current = current.Next;
            count++;
        }

        // If we reached a valid node before the one to delete, remove the next node
        if (current != null && current.Next != null)
        {
            myLList.Remove(current.Next);
        }
    }
}
