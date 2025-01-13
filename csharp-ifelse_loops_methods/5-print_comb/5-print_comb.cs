using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i <= 99; i++)
        {
            // Print the current number, formatted to always show two digits
            Console.Write($"{i:D2}");
            
            // Check if it's the last number (99) to avoid trailing comma
            if (i != 99)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine(); // Print a newline after all numbers
    }
}
