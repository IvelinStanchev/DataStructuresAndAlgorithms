using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_SetImplementation
{
    class SetImplementation
    {
        static void Main()
        {
            HashSet<int> numbers = new HashSet<int>();

            numbers.Add(5);
            numbers.Add(10);
            numbers.Add(8);

            Console.WriteLine("The count of numbers is: {0}", numbers.Count);
        }
    }
}
