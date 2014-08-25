using System;
using System.Collections.Generic;

namespace _11_LinkedListImplementation
{
    class LinkedListImplementation
    {
        static void Main()
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);
            linkedList.AddLast(5);
            linkedList.AddLast(6);
            linkedList.AddLast(7);
            linkedList.AddLast(8);
            linkedList.AddLast(9);
            linkedList.AddLast(10);

            foreach (var element in linkedList)
            {
                Console.WriteLine(element);
            }
        }
    }
}
