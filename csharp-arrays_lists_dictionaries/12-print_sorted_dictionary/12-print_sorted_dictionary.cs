using System;
using System.Collections.Generic;

public class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        // Create a list of keys from the dictionary
        List<string> keys = new List<string>(myDict.Keys);

        // Sort the keys alphabetically
        keys.Sort();

        // Iterate through the sorted keys and print the key-value pairs
        foreach (string key in keys)
        {
            Console.WriteLine($"{key}: {myDict[key]}");
        }
    }
}
