using System;
using System.Collections.Generic;

public class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList == null || myList.Count == 0)
            return "None";

        string bestKey = null;
        int highestValue = int.MinValue;

        foreach (KeyValuePair<string, int> entry in myList)
        {
            if (entry.Value > highestValue)
            {
                highestValue = entry.Value;
                bestKey = entry.Key;
            }
        }

        return bestKey;
    }
}
