using System;
using System.Collections.Generic;

class SequenceOfPositiveNumbers
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

        int sum = CalculateSum(inputNumbers);
        int countOfInputNumbers = inputNumbers.Count;
        double average = CalculateAverage(sum, countOfInputNumbers);

        Console.WriteLine("The sum of the numbers is: {0}", sum);
        Console.WriteLine("The average of the numbers is: {0}", average);
    }

    private static double CalculateAverage(int sum, int countOfInputNumbers)
    {
        return sum / countOfInputNumbers;
    }

    private static int CalculateSum(List<int> inputNumbers)
    {
        int sum = 0;

        for (int i = 0; i < inputNumbers.Count; i++)
        {
            sum += inputNumbers[i];
        }

        return sum;
    }
}
