using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ImplementingBiDictionary
{
    class ImplementingBiDictionary
    {
        private static Random random = new Random();

        static void Main()
        {
            BiDictionary<int, int, string> biDictionary = new BiDictionary<int, int, string>();

            for (int i = 0; i < 10; i++)
            {
                biDictionary.Add(i, i * random.Next(10), string.Format("entry {0}", i));
            }

            var foundEntryByFirstKey = biDictionary.FindUsingFirstKey(5);

            Console.Write("Found entry by first key:");
            foreach (var entry in foundEntryByFirstKey)
            {
                Console.Write(" " + entry);
            }

            Console.WriteLine();

            var foundEntryBySecondKey = biDictionary.FindUsingSecondKey(8);

            if (foundEntryBySecondKey.Count == 0)
            {
                Console.Write("No entry was found by searching with second key!");
            }
            else
            {
                Console.Write("Found entry by second key:");

                foreach (var entry in foundEntryBySecondKey)
                {
                    Console.Write(" " + entry);
                }
            }

            Console.WriteLine();

            var foundEntryByBothKeys = biDictionary.FindUsingBothKeys(1, 2);

            if (foundEntryByBothKeys.Count == 0)
            {
                Console.Write("No entry was found by searching with both keys!");
            }
            else
            {
                Console.Write("Found entry by both keys:");

                foreach (var entry in foundEntryByBothKeys)
                {
                    Console.Write(" " + entry);
                }
            }

            Console.WriteLine();
        }
    }
}
