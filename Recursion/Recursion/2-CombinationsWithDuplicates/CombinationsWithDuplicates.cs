using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CombinationsWithDuplicates
{
    class CombinationsWithDuplicates
    {
        static void Main()
        {
            Console.Write("Enter a number for n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter a number for k: ");
            int k = int.Parse(Console.ReadLine());

            int[] values = new int[k];

            GenerateCombinations(0, values, n, 1);
        }

        private static void GenerateCombinations(int k, int[] values, int n, int index)
        {
            if (k >= values.Length)
            {
                Print(values);
            }
            else
            {
                for (int i = index; i <= n; i++)
                {
                    values[k] = i;
                    GenerateCombinations(k + 1, values, n, i);
                }
            }
        }

        private static void Print(int[] values)
        {
            foreach (var value in values)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine();
        }
    }
}
