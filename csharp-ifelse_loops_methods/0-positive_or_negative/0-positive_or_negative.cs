using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10, 10);

        // Check if the number is positive, zero, or negative and print the result
        if (number > 0)
        {
            Console.WriteLine($"{number} is positive");
        }
        else if (number == 0)
        {
            Console.WriteLine($"{number} is zero");
        }
        else
        {
            Console.WriteLine($"{number} is negative");
        }
    }
}
