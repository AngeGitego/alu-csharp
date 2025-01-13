using System;

class Program
{
    static void Main(string[] args)
    {
        string result = "";

        // Using a single loop to accumulate all the numbers in the result string
        for (int i = 0; i <= 99; i++)
        {
            result += string.Format("{0:D2}", i);

            // If it's not the last number, add a comma and space
            if (i != 99)
            {
                result += ", ";
            }
        }

        // Use Console.Write only twice
        Console.Write(result);
        Console.WriteLine();  // New line after all numbers are printed
    }
}
