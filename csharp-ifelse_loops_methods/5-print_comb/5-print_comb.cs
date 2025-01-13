using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 100; i++)
        {
            // Print the number with two digits
            Console.Write("{0:D2}", i);

            // Print a comma and space unless it's the last number (99)
            if (i < 99) 
                Console.Write(", ");
        }

        // Print a newline at the end after all numbers are printed
        Console.WriteLine();
    }
}
