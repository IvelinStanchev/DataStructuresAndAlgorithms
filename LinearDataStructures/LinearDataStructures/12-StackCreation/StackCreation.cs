using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_StackCreation
{
    class StackCreation
    {
        static void Main()
        {
            MyStack<int> myStack = new MyStack<int>();

            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            Console.WriteLine("Stacks capacity after adding 4 elements: {0}", myStack.Capacity);
            myStack.Push(5);
            Console.WriteLine("Stacks capacity after adding 5 elements: {0}", myStack.Capacity);
            myStack.Pop();
        }
    }
}
