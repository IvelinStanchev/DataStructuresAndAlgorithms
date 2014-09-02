using System;
using System.Collections.Generic;

class Print50MembersOfGivenSequence
{
    static void Main()
    {
        Queue<int> sequence = new Queue<int>();

        int N = int.Parse(Console.ReadLine());

        List<int> first50Numbers = GetFirst50Numbers(N);

        for (int i = 0; i < 50; i++)
        {
            Console.Write(first50Numbers[i]);
            if (i < 49)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine();
    }

    private static List<int> GetFirst50Numbers(int startingNumber)
    {
        List<int> first50Numbers = new List<int>();
        Queue<int> sequence = new Queue<int>();

        sequence.Enqueue(startingNumber);
        first50Numbers.Add(startingNumber);

        while (first50Numbers.Count < 50)
        {
            int first = sequence.Dequeue();
            int second = first + 1;
            int third = 2 * first + 1;
            int fourth = first + 2;

            sequence.Enqueue(second);
            sequence.Enqueue(third);
            sequence.Enqueue(fourth);

            first50Numbers.Add(second);
            first50Numbers.Add(third);
            first50Numbers.Add(fourth);
        }

        return first50Numbers;
    }
}