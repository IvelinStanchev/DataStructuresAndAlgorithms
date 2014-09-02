using System;
using System.Collections.Generic;

class FindMajorantOfAnArray
{
    static void Main()
    {
        List<int> sequence = new List<int>() { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
        Dictionary<int, int> occurrences = new Dictionary<int, int>();
        int sequenceLength = sequence.Count;

        FindOccurrences(sequence, occurrences);

        bool hasMajorant = false;
        foreach (var keyValuePair in occurrences)
        {
            if (keyValuePair.Value >= (sequenceLength / 2) + 1)
            {
                Console.WriteLine(keyValuePair.Key);
                hasMajorant = true;
            }
        }

        if (!hasMajorant)
        {
            Console.WriteLine("There is no majorant!");
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
