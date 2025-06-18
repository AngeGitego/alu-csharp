using System;
using System.Collections.Generic;

public class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        HashSet<int> set1 = new HashSet<int>(list1);
        HashSet<int> set2 = new HashSet<int>(list2);
        List<int> commonList = new List<int>();

        foreach (int num in set1)
        {
            if (set2.Contains(num))
            {
                commonList.Add(num);
            }
        }

        // Implementing manual sorting (Bubble Sort)
        for (int i = 0; i < commonList.Count - 1; i++)
        {
            for (int j = 0; j < commonList.Count - i - 1; j++)
            {
                if (commonList[j] > commonList[j + 1])
                {
                    int temp = commonList[j];
                    commonList[j] = commonList[j + 1];
                    commonList[j + 1] = temp;
                }
            }
        }

        return commonList;
    }
}
