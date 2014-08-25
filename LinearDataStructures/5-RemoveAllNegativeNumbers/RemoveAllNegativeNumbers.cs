using System;
using System.Collections.Generic;
using System.Linq;

class RemoveAllNegativeNumbers
{
    static void Main()
    {
        List<int> sequence = new List<int>() { 4, -2, 2, 5, -5, 2, 10, -10, 15, -15 };

        var sequenceWithRemovedNegativeNumbers = RemoveNegativeNumbers(sequence);

        PrintPositiveSequence(sequenceWithRemovedNegativeNumbers);
    }

    private static void PrintPositiveSequence(List<int> sequenceWithRemovedNegativeNumbers)
    {
        Console.WriteLine(string.Join(", ", sequenceWithRemovedNegativeNumbers));
    }

    private static List<int> RemoveNegativeNumbers(List<int> sequence)
    {
        sequence.RemoveAll(x => x < 0);

        return sequence;
    }
}
