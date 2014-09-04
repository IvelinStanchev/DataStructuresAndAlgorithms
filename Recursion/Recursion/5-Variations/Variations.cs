using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Variations
{
    class Variations
    {
        static void Main()
        {
            int n = 3;
            int k = 2;
            string[] set = new string[] { "hi", "a", "b" };
            string[] values = new string[k];

            GenerateVariations(0, values, n, set);
        }

        private static void GenerateVariations(int index, string[] values, int n, string[] set)
        {
            if (index >= set.Length - 1)
            {
                Print(values);
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    values[index] = set[i];
                    GenerateVariations(index + 1, values, n, set);
                }
            }
        }

        private static void Print(string[] values)
        {
            foreach (var element in values)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();
        }
    }
}
