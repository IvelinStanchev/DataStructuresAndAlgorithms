using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_DynamicQueue
{
    class DynamicQueue
    {
        static void Main()
        {
            LinkedQueue<int> queue = new LinkedQueue<int>();

            for (int i = 1; i <= 15; i++)
            {
                queue.Push(i);
            }

            Console.WriteLine(queue.Peek());
            Console.WriteLine();

            for (int i = 0, len = queue.Count; i < len; i++)
            {
                Console.WriteLine(queue.Pop());
            }
        }
    }
}
