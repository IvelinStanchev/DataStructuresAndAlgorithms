using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNumbersWhichOccurOddNumberOfTimes
{
    static void Main()
    {
        List<int> sequence = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
        Dictionary<int, int> occurrences = new Dictionary<int, int>();

        FindOccurrences(sequence, occurrences);

        sequence.RemoveAll(x => occurrences[x] % 2 != 0);

        PrintSequence(sequence);
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

    private static void PrintSequence(List<int> sequence)
    {
        Console.WriteLine("The sequence with the numbers which occur even number of times is: ");
        Console.WriteLine(string.Join(", ", sequence));
    }
}