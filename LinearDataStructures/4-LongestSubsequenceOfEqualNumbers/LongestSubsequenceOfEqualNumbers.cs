using System;
using System.Collections.Generic;

class LongestSubsequenceOfEqualNumbers
{
    static void Main()
    {
        List<int> sequence = new List<int>() { 4, 2, 2, 5, 5, 2, 3, 2, 3, 1, 5, 2 }; //Result must be 2, 2

        List<int> result = FindLongestSequenceOfEqualNumber(sequence);

        PrintLongestResult(result);
    }

    private static void PrintLongestResult(List<int> result)
    {
        Console.WriteLine(string.Join(", ", result));
    }

    private static List<int> FindLongestSequenceOfEqualNumber(List<int> sequence)
    {
        int bestNumber = sequence[0];
        int repeatingTimes = 1;
        int bestRepeatingTimes = 1;

        for (int i = 1; i < sequence.Count; i++)
        {
            if (sequence[i] == sequence[i - 1])
            {
                repeatingTimes++;
                if (repeatingTimes > bestRepeatingTimes)
                {
                    bestRepeatingTimes = repeatingTimes;
                    bestNumber = sequence[i];
                }
            }
            else
            {
                if (repeatingTimes != 1)
                {
                    repeatingTimes = 1;
                }
            }
        }

        List<int> longestSequence = new List<int>();
        for (int i = 0; i < bestRepeatingTimes; i++)
        {
            longestSequence.Add(bestNumber);
        }

        return longestSequence;
    }
}
