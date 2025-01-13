using System;

class Program
{
    // Number class with the Add method
    class Number
    {
        // Method to add two integers and return the result
        public static int Add(int a, int b)
        {
            return a + b;  // Return the sum of a and b
        }
    }

    static void Main(string[] args)
    {
        // Testing the Add method
        Console.WriteLine("{0}", Number.Add(1, 2));   // Outputs: 3
        Console.WriteLine("{0}", Number.Add(98, 0));  // Outputs: 98
        Console.WriteLine("{0}", Number.Add(100, -2)); // Outputs: 98
    }
}
