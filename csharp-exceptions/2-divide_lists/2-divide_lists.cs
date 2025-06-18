using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> result = new List<int>();

        try
        {
            if (list1.Count < listLength || list2.Count < listLength)
            {
                Console.WriteLine("Out of range");
                return result;
            }

            for (int i = 0; i < listLength; i++)
            {
                try
                {
                    if (list2[i] == 0)
                    {
                        Console.WriteLine("Cannot divide by zero");
                        result.Add(0);
                    }
                    else
                    {
                        result.Add(list1[i] / list2[i]);
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Out of range");
                    break;
                }
            }
        }
        catch (Exception)
        {
            // Handle other unexpected errors.
            Console.WriteLine("An error occurred");
        }

        return result;
    }
}
