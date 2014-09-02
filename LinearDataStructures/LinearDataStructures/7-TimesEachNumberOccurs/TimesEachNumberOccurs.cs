using System;
using System.Collections.Generic;

class TimesEachNumberOccurs
{
    static void Main()
    {
        List<int> sequence = new List<int>() { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
        Dictionary<int, int> occurrences = new Dictionary<int, int>();

        FindOccurrences(sequence, occurrences);

        PrintOccurrences(occurrences);
    }

    private static void PrintOccurrences(Dictionary<int, int> occurrences)
    {
        foreach (var keyValuePair in occurrences)
        {
            Console.WriteLine(keyValuePair.Key + " -> " + keyValuePair.Value + " times");
        }
    }

    private static void FindOccurrences(List<int> sequence, Dictionary<int, int> occurrences)
    {
        for (int i = 0; i < sequence.Count; i++)
        {
            if (!occurrences.ContainsKey(sequence[i]))
            {
                occurrences.Add(sequence[i], 1);
            }
            else
            {
                occurrences[sequence[i]]++;
            }
        }
    }
}
