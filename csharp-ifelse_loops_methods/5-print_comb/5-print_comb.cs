using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i <= 99; i++)
        {
            // Print number with leading zero if necessary
            Console.Write("{0:D2}", i);

            // If it's not the last number, print a comma and a space
            if (i != 99)
                Console.Write(", ");
        }
        // Print a new line after the last number
        Console.WriteLine();
    }
}
