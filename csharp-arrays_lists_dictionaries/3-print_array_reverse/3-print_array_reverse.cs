using System;

public class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            Console.WriteLine(); // Print an empty line for null or empty array
            return;
        }

        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write(array[i]);
            if (i > 0)
                Console.Write(" "); // Add a space between elements
        }
        Console.WriteLine(); // End the line after printing the array
    }
}
