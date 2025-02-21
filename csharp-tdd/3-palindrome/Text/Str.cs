using System;
using System.Text.RegularExpressions;

namespace Text
{
    public  class Str
    {
        public static bool IsPalindrome(string s)
        {
            // Remove spaces, punctuation, and convert to lowercase
            string cleanedString = Regex.Replace(s, @"[^a-zA-Z0-9]", "").ToLower();

            // Check if the string is equal to its reverse
            int left = 0;
            int right = cleanedString.Length - 1;

            while (left < right)
            {
                if (cleanedString[left] != cleanedString[right])
                {
                    return false; // Not a palindrome
                }
                left++;
                right--;
            }

            return true; // It's a palindrome
        }
    }
}
