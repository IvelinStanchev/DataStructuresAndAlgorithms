using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter N");
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine();

        Stack<int> numbersInDescendingOrder = new Stack<int>();

        for (int i = 0; i < N; i++)
		{
            int rowNumber = int.Parse(Console.ReadLine());
            numbersInDescendingOrder.Push(rowNumber);
		}

        Console.WriteLine();

        PrintStack(numbersInDescendingOrder);
    }

    private static void PrintStack(Stack<int> numbersInDescendingOrder)
    {
        int elementsCount = numbersInDescendingOrder.Count;

        for (int i = 0; i < elementsCount; i++)
        {
            Console.WriteLine(numbersInDescendingOrder.Pop());
        }
    }
}
