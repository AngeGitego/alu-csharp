using System;
using System.Collections.Generic;

public class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        // Check if the dictionary is empty
        if (myList == null || myList.Count == 0)
        {
            return "None";
        }

        // Initialize variables to track the key with the highest value
        string bestKey = null;
        int highestScore = int.MinValue;

        // Iterate through the dictionary
        foreach (var item in myList)
        {
            if (item.Value > highestScore)
            {
                highestScore = item.Value;
                bestKey = item.Key;
            }
        }

        return bestKey;
    }
}
