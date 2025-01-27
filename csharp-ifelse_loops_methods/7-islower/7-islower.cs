using System;

public class Character
{
    public static bool IsLower(char c)
    {
        // Check if the character is between 'a' and 'z'
        if (c >= 'a' && c <= 'z')
        {
            return true;
        }
        return false;
    }
}
