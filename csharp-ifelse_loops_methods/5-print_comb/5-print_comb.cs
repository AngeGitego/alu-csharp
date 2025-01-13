using System;

class Program
{
    static void Main(string[] args)
    {
        string result = "";  // Initialize an empty string to accumulate the output

        // Loop to print numbers from 0 to 99
        for (int i = 0; i < 100; i++)
        {
            result += $"{i:D2}";  // Add the current number formatted as two digits

            if (i < 99) // If not the last number, add a comma and space
                result += ", ";
        }

        Console.WriteLine(result);  // Output the accumulated result at once
    }
}
