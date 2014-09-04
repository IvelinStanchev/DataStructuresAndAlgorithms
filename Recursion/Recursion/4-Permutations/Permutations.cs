using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Permutations
{
    class Permutations
    {
        static void Main()
        {
            Console.WriteLine("Enter a nubmer for n:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            GenerateAllCombinations(0, n, arr);
        }

        private static void GenerateAllCombinations(int index, int n, int[] arr)
        {
            if (index == arr.Length)
            {
                Print(arr);
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    bool checkNumber = true;
                    for (int j = 0; j < index; j++)
                    {
                        if (arr[j] == i)
                        {
                            checkNumber = false;
                        }
                    }
                    if (checkNumber)
                    {
                        arr[index] = i;
                        GenerateAllCombinations(index + 1, n, arr);
                    }
                }
            }
        }

        private static void Print(int[] arr)
        {
            Console.Write("{");
            Console.Write(string.Join(", ", arr));
            Console.WriteLine("}");
        }
    }
}
