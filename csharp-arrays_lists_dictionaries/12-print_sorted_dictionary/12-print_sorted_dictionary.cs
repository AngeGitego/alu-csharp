using System;
using System.Collections.Generic;

namespace PrintSortedDictionaryApp
{
    public class Dictionary
    {
        public static void PrintSorted(Dictionary<string, string> myDict)
        {
            if (myDict == null || myDict.Count == 0)
                return;

            // Get the keys and sort them
            List<string> sortedKeys = new List<string>(myDict.Keys);
            sortedKeys.Sort();

            // Iterate through the sorted keys and print the key-value pairs
            foreach (string key in sortedKeys)
            {
                Console.WriteLine($"{key}: {myDict[key]}");
            }
        }
    }
}
