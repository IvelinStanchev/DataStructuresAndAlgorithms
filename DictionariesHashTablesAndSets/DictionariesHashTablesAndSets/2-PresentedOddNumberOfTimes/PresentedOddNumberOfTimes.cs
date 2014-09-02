using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PresentedOddNumberOfTimes
{
    class PresentedOddNumberOfTimes
    {
        static void Main()
        {
            //If you want to use your own values just uncomment the rows below
            //int N = int.Parse(Console.ReadLine());
            //string[] arrayOfStrings = new string[N];
            //for (int i = 0; i < N; i++)
            //{
            //    arrayOfStrings[i] = Console.ReadLine();
            //}
            string[] arrayOfStrings = new string[] { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };
            Dictionary<string, int> occurrences = new Dictionary<string, int>();

            occurrences = FindOccurrences(arrayOfStrings);

            List<string> stringsOccuredOddNumberOfTimes = ExtractStringsWhichOccurOddNumberOfTimes(occurrences);

            Console.Write("{ ");

            for (int i = 0; i < stringsOccuredOddNumberOfTimes.Count; i++)
            {
                Console.Write(stringsOccuredOddNumberOfTimes[i]);
                if (i != stringsOccuredOddNumberOfTimes.Count - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine(" }");
        }

        private static List<string> ExtractStringsWhichOccurOddNumberOfTimes(Dictionary<string, int> occurrences)
        {
            List<string> stringsOccuredOddNumberOfTimes = new List<string>();

            foreach (var occurrence in occurrences)
            {
                if (occurrence.Value % 2 != 0)
                {
                    stringsOccuredOddNumberOfTimes.Add(occurrence.Key);
                }
            }

            return stringsOccuredOddNumberOfTimes;
        }

        private static Dictionary<string, int> FindOccurrences(string[] arrayOfStrings)
        {
            Dictionary<string, int> occurrences = new Dictionary<string, int>();

            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                if (!occurrences.ContainsKey(arrayOfStrings[i]))
                {
                    occurrences.Add(arrayOfStrings[i], 1);
                }
                else
                {
                    occurrences[arrayOfStrings[i]]++;
                }
            }

            return occurrences;
        }
    }
}
