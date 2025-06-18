using System;
using System.Collections.Generic;

public class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        // Check if the index is out of range
        if (index < 0 || index >= myList.Count)
        {
            Console.WriteLine("Index is out of range");
            return myList;
        }

        // Create a new list to store updated items
        List<int> updatedList = new List<int>();

        // Copy all elements except the one at the specified index
        for (int i = 0; i < myList.Count; i++)
        {
            if (i != index)
            {
                updatedList.Add(myList[i]);
            }
        }

        // Clear the original list and add back the updated elements
        myList.Clear();
        myList.AddRange(updatedList);

        return myList;
    }
}
