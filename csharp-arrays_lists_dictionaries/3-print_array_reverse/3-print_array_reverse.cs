using System;

public class Array
{
    public static void Reverse(int[] array)
    {
        // Handle null array explicitly
        if (array == null)
        {
            Console.WriteLine(); // Print an empty line for null array
            return;
        }

        // Handle empty array (no need to print anything extra, just a blank line)
        if (array.Length == 0)
        {
            Console.WriteLine();
            return;
        }

        // Reverse and print elements
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write(array[i]);
            if (i > 0)
                Console.Write(" "); // Add a space between elements
        }
        Console.WriteLine(); // End the line after printing the array
    }
}
