using System;
using System.Linq;
using System.Collections.Generic;

namespace Text
{
    public class Str
    {
        public static int UniqueChar(string s)
        {
            // Dictionary to store the frequency of each character
            var charCount = new Dictionary<char, int>();

            // Count the occurrences of each character
            foreach (var c in s)
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

            // Loop through the string again to find the first non-repeating character
            for (int i = 0; i < s.Length; i++)
            {
                if (charCount[s[i]] == 1)
                {
                    return i;
                }
            }

            // Return -1 if no non-repeating character is found
            return -1;
        }
    }
}
