using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 9; i++)  // First digit loop
        {
            for (int j = i + 1; j <= 9; j++)  // Second digit loop (ensures digits are different and in ascending order)
            {
                Console.Write($"{i}{j}");  // Print the combination
                
                // If it's not the last combination, print a comma and space
                if (i != 8 || j != 9)
                {
                    Console.Write(", ");
                }
            }
        }
        Console.WriteLine();  // Print a newline after all combinations
    }
}
