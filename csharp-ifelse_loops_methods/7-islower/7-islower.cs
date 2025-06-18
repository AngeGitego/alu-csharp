using System;

class Character
{
    public static bool IsLower(char c)
    {
        // Check if the character is between 'a' and 'z' in ASCII (97-122)
        return c >= 'a' && c <= 'z';
    }
}
