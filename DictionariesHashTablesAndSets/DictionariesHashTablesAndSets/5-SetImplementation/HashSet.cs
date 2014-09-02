using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4_HashTableImplementation;

namespace _5_SetImplementation
{
    class HashSet<T>
    {
        HashTable<int, T> hashTable;

        public HashSet()
        {
            hashTable = new HashTable<int, T>();

        }

        public void Add(T value)
        {
            hashTable.Add(value.GetHashCode(), value);
        }

        public T Find(T value)
        {
            return hashTable.Find(value.GetHashCode());
        }

        public void Remove(T value)
        {
            hashTable.Remove(value.GetHashCode());
        }

        public int Count
        {
            get
            {
                return hashTable.Count;
            }
        }

        public void Clear()
        {
            hashTable.Clear();
        }

        public T this[T index]
        {
            get
            {
                return hashTable[index.GetHashCode()];
            }
            set
            {
                hashTable[index.GetHashCode()] = value;
            }
        }
    }
}
