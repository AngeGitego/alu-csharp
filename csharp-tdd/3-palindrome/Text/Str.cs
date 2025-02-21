using System;

namespace Text
{
    public class Str
    {
        public static bool IsPalindrome(string s)
        {
            // Remove spaces, punctuation, and convert to lowercase
            s = new string(s.Where(c => Char.IsLetterOrDigit(c)).ToArray()).ToLower();

            // Check if the string equals its reverse
            return s == new string(s.Reverse().ToArray());
        }
    }
}
