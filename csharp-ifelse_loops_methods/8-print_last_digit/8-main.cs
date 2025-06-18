using System;

partial class Program  // Add the 'partial' keyword here
{
    static void Main(string[] args)
    {
        int r;

        // Calling the method for different numbers
        Number.PrintLastDigit(98);   // prints 8
        Number.PrintLastDigit(0);    // prints 0
        r = Number.PrintLastDigit(-1024); // prints 4, stores it in r
        Console.WriteLine(r); // prints 4 (the last digit of -1024)
    }
}
