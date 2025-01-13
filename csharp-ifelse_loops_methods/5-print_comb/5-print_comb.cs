using System;

class Program
{
    static void Main(string[] args)
    {
        // Loop to print all numbers from 0 to 99 in the desired format
        for (int i = 0; i < 100; i++)
        {
            if (i < 99)
                Console.Write($"{i:D2}, ");
            else
                Console.WriteLine($"{i:D2}"); // Print the last number with a newline
        }
    }
}
