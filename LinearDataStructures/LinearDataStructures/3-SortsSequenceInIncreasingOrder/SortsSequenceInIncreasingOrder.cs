using System;
using System.Collections.Generic;

class SortsSequenceInIncreasingOrder
{
    static void Main()
    {
        string currentRowNumberAsString = String.Empty;
        int currentRowNumber = 0;
        List<int> inputNumbers = new List<int>();

        while (true)
        {
            currentRowNumberAsString = Console.ReadLine();

            if (currentRowNumberAsString == "")
            {
                break;
            }
            else
            {
                currentRowNumber = int.Parse(currentRowNumberAsString);
                inputNumbers.Add(currentRowNumber);
            }
        }

        inputNumbers.Sort();

        PrintSequence(inputNumbers);
    }

    private static void PrintSequence(List<int> inputNumbers)
    {
        for (int i = 0; i < inputNumbers.Count; i++)
        {
            Console.WriteLine(inputNumbers[i]);
        }
    }
}
