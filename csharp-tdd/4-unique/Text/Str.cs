using System.Collections.Generic;

namespace Text
{
    public static class Str
{
    public static int UniqueChar(string input)
    {
        var charCount = new Dictionary<char, int>();

        // Count occurrences of each character
        foreach (var c in input)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }

        // Find the first unique character
        for (int i = 0; i < input.Length; i++)
        {
            if (charCount[input[i]] == 1)
            {
                return i; // Return the index of the first unique character
            }
        }

        return -1; // No unique character found
    }
}

    }

