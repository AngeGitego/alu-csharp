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
            if (string.IsNullOrEmpty(s))
                return 0;

            int wordCount = 1; // The first word is always counted
            foreach (char c in s)
            {
                if (char.IsUpper(c))
                    wordCount++;
            }
            return wordCount;
        }
    }
}
