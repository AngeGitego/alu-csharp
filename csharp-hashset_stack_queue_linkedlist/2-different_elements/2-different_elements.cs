using System;
using System.Collections.Generic;

public class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        HashSet<int> set1 = new HashSet<int>(list1);
        HashSet<int> set2 = new HashSet<int>(list2);
        List<int> differentList = new List<int>();

        // Add elements that are in list1 but not in list2
        foreach (int num in set1)
        {
            if (!set2.Contains(num))
            {
                differentList.Add(num);
            }
        }

        // Add elements that are in list2 but not in list1
        foreach (int num in set2)
        {
            if (!set1.Contains(num))
            {
                differentList.Add(num);
            }
        }

        // Implementing manual sorting (Bubble Sort)
        for (int i = 0; i < differentList.Count - 1; i++)
        {
            for (int j = 0; j < differentList.Count - i - 1; j++)
            {
                if (differentList[j] > differentList[j + 1])
                {
                    int temp = differentList[j];
                    differentList[j] = differentList[j + 1];
                    differentList[j + 1] = temp;
                }
            }
        }

        return differentList;
    }
}
