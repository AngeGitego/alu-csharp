using System;

public class Array
{
    public static int[] CreatePrint(int size)
    {
        // Handle size less than 0
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        // Handle size equal to 0
        if (size == 0)
        {
            Console.WriteLine();
            return new int[0];
        }

        // Create and populate the array
        int[] newArray = new int[size];
        for (int i = 0; i < size; i++)
        {
            newArray[i] = i;
        }

        // Print the array
        Console.WriteLine(string.Join(" ", newArray));

        // Return the new array
        return newArray;
    }
}
