using System;
using System.Collections.Generic;

public class List
{
    public static List<int>? CreatePrint(int size)
    {
        // Handle negative size
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        // Create and populate the list
        List<int> newList = new List<int>();
        for (int i = 0; i < size; i++)
        {
            newList.Add(i);
            Console.Write(i); // Print the current element
            if (i < size - 1)
                Console.Write(" "); // Add a space between elements
        }

        Console.WriteLine(); // End the line after printing
        return newList;
    }
}
