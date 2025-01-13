using System;

class Number
{
    // This method checks and prints the last digit of the number
    public static int PrintLastDigit(int number)
    {
        // Get the last digit, use Math.Abs for handling negative numbers
        int lastDigit = Math.Abs(number) % 10;
        
        // Print the last digit
        Console.WriteLine(lastDigit);
        
        // Return the last digit
        return lastDigit;
    }
}
