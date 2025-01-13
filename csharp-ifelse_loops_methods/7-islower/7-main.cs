using System;

class Program
{
    static void Main(string[] args)
    {
        // Array of characters to test
        char[] letters = { 'a', 'A', 'Q', 'h', '9', 'B', 'g' };
        int i;

        // Loop through the array and check each character
        for (i = 0; i < letters.Length; i++)
        {
            // Check if the current character is lowercase
            if (Character.IsLower(letters[i]))
                Console.WriteLine("{0} is lowercase", letters[i]);
            else
                Console.WriteLine("{0} is uppercase", letters[i]);
        }
    }
}
