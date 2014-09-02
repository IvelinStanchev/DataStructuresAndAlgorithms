using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_HashTableImplementation
{
    class HashTableImplementation
    {
        static void Main()
        {
            HashTable<string, int> people = new HashTable<string, int>();

            people.Add("Pesho", 5);
            people.Add("Gosho", 2);
            people.Add("Kiro", 8);

            foreach (var person in people)
            {
                Console.WriteLine("Name: {0} -> Value: {1}", person.Key, person.Value);
            }

            people.Remove("Pesho");
            Console.WriteLine(new string('-', 50));

            foreach (var person in people)
            {
                Console.WriteLine("Name: {0} -> Value: {1}", person.Key, person.Value);
            }

            people.Add("Pesho", 10);
            Console.WriteLine(new string('-', 50));

            foreach (var person in people)
            {
                Console.WriteLine("Name: {0} -> Value: {1}", person.Key, person.Value);
            }

            Console.WriteLine(new string('-', 50));

            Console.WriteLine(people["Pesho"]);

            Console.WriteLine(new string('-', 50));

            Console.WriteLine(people.Find("Gosho"));

            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Count of people before clear: {0}", people.Count);

            people.Clear();

            Console.WriteLine("Count of people after clear: {0}", people.Count);

            foreach (var person in people)
            {
                Console.WriteLine("Name: {0} -> Value: {1}", person.Key, person.Value);
            }
        }
    }
}
