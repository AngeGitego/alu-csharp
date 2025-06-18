using System;
using System.Collections.Generic;

public class List
{
    public static int MaxInteger(List<int> myList)
    {
        // Check if the list is empty
        if (myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return -1;
        }

        // Initialize max with the first element of the list
        int max = myList[0];

        // Iterate through the list to find the maximum value
        foreach (int num in myList)
        {
            if (num > max)
            {
                max = num;
            }
        }

        return max;
    }
}
