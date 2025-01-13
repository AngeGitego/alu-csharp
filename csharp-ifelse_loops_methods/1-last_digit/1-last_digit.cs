using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int number = random.Next(-10000, 10000);

        int lastDigit = number % 10; // Get the last digit of the number

        Console.Write($"The last digit of {number} is {lastDigit} ");

        if (lastDigit > 5)
        {
            Console.WriteLine("and is greater than 5");
        }
        else if (lastDigit == 0)
        {
            Console.WriteLine("and is 0");
        }
        else // lastDigit < 6 and not 0
        {
            Console.WriteLine("and is less than 6 and not 0");
        }
    }
}
