using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_CountsOccurrences
{
    class CountsOccurrences
    {
        static void Main()
        {
            //If you want to use your own values just uncomment the rows below
            //int N = int.Parse(Console.ReadLine());
            //double[] arrayOfNumbers = new double[N];
            //for (int i = 0; i < N; i++)
            //{
            //    arrayOfNumbers[i] = double.Parse(Console.ReadLine());
            //}
            double[] arrayOfNumbers = new double[] { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };
            Dictionary<double, int> occurrences = new Dictionary<double, int>();

            occurrences = FindOccurrences(arrayOfNumbers);

            foreach (var occurrence in occurrences)
            {
                Console.WriteLine("{0} -> {1} times", occurrence.Key, occurrence.Value);
            }
        }

        private static Dictionary<double, int> FindOccurrences(double[] arrayOfNumbers)
        {
            Dictionary<double, int> occurrences = new Dictionary<double, int>();

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (!occurrences.ContainsKey(arrayOfNumbers[i]))
                {
                    occurrences.Add(arrayOfNumbers[i], 1);
                }
                else
                {
                    occurrences[arrayOfNumbers[i]]++;
                }
            }

            return occurrences;
        }
    }
}
