using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AllSubsetsOfKStrings
{
    class AllSubsetsOfKStrings
    {
        static void Main()
        {
            int k = 2;
            string[] set = { "test", "rock", "fun" };
            string[] result = new string[k];

            GenerateSubsets(0, 0, result, set);
        }

        static void GenerateSubsets(int startIndex, int index, string[] result, string[] setOfStrings)
        {
            if (index > result.Length - 1)
            {
                Print(result);
            }
            else
            {
                for (int i = startIndex; i < setOfStrings.Length; i++)
                {
                    if (index < result.Length)
                    {
                        result[index] = setOfStrings[i];
                    }
                    GenerateSubsets(i + 1, index + 1, result, setOfStrings);
                }
            }
        }

        static void Print(string[] result)
        {
            Console.WriteLine(String.Join(", ", result));
        }
    }
}
