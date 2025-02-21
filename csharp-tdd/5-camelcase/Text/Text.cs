namespace Text
{
    public class Str
    {
        /// <summary>
        /// Determines how many words are in a camelCase string.
        /// </summary>
        /// <param name="s">The camelCase string.</param>
        /// <returns>The number of words in the string.</returns>
        public static int CamelCase(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            s = s.Trim(); // Trim leading/trailing spaces

            int words = 1; // Start with 1 for the first word
            foreach (var c in s)
            {
                // Increment words if an uppercase letter is found
                if (char.IsUpper(c))
                    words++;
            }

            return words;
        }
    }
}
