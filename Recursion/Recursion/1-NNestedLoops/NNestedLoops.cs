using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_NNestedLoops
{
    class NNestedLoops
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int[] values = new int[N];

            GenerateVariant(N - 1, values, N);
        }

        private static void GenerateVariant(int index, int[] values, int n)
        {
            if (index == -1)
            {
                Print(values);
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    values[index] = i;
                    GenerateVariant(index - 1, values, n);
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
