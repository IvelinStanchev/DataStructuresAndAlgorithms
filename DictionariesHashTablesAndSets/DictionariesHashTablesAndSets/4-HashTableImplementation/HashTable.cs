using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_HashTableImplementation
{
    public class HashTable<K, V> : IEnumerable<KeyValuePair<K, V>>
    {
        public const int InitialValueSize = 4;

        LinkedList<KeyValuePair<K, V>>[] values;

        public HashTable()
        {
            this.values = new LinkedList<KeyValuePair<K, V>>[InitialValueSize];
        }

        public int Count { get; private set; }

        public int Capacity
        {
            get
            {
                return this.values.Length;
            }
        }

        public void Add(K key, V value)
        {
            var hash = HashKey(key);

            if (this.values[hash] == null)
            {
                this.values[hash] = new LinkedList<KeyValuePair<K, V>>();
            }

            var alreadyHasHKey = this.values[hash].Any(p => p.Key.Equals(key));

            if (alreadyHasHKey)
            {
                throw new ArgumentException("Key already exist!");
            }

            var pair = new KeyValuePair<K, V>(key, value);
            this.values[hash].AddLast(pair);
            this.Count++;

            if (this.Count >= 0.75 * this.Capacity)
            {
                this.ResizeAndReaddValues();
            }
        }

        public V this[K key]
        {
            get
            {
                return this.Find(key);
            }
            set
            {
                int hash = this.HashKey(key);

                if (this.values[hash] == null)
                {
                    throw new ArgumentException("There is no element with this key");
                }
                else
                {
                    bool isFound = false;
                    var next = this.values[hash].First;
                    while (next != null)
                    {
                        if (next.Value.Key.Equals(key))
                        {
                            LinkedListNode<KeyValuePair<K, V>> node =
                                new LinkedListNode<KeyValuePair<K, V>>(new KeyValuePair<K, V>(key, value));
                            this.values[hash].AddAfter(next, node);
                            this.values[hash].Remove(next);
                            isFound = true;
                            break;
                        }
                        next = next.Next;
                    }
                    if (isFound == false)
                    {
                        throw new ArgumentException("There is no element with this key");
                    }
                }
            }
        }

        public void Remove(K key)
        {
            int hash = this.HashKey(key);

            if (this.values[hash] == null)
            {
                throw new ArgumentException("There is no element with this key");
            }
            else
            {
                bool isFound = false;
                var next = this.values[hash].First;
                while (next != null)
                {
                    if (next.Value.Key.Equals(key))
                    {
                        this.values[hash].Remove(next);
                        isFound = true;
                        this.Count -= 1;
                    }
                    next = next.Next;
                }
                if (isFound == false)
                {
                    throw new ArgumentException("There is no element with this key");
                }
            }
        }

        public void Clear()
        {
            this.values = new LinkedList<KeyValuePair<K, V>>[InitialValueSize];
            this.Count = 0;
        }

        public V Find(K key)
        {
            var hash = HashKey(key);

            if (this.values[hash] == null)
            {
                throw new ArgumentException("There is no element with this key");
            }
            else
            {
                var next = this.values[hash].First;
                while (next != null)
                {
                    if (next.Value.Key.Equals(key))
                    {
                        return next.Value.Value;
                    }
                    next = next.Next;
                }
                throw new ArgumentException("There is no element with this key");
            }
        }

        public List<K> Keys
        {
            get
            {
                List<K> keys = new List<K>();
                for (int i = 0; i < this.values.Length; i++)
                {
                    if (this.values[i] != null)
                    {
                        var next = this.values[i].First;
                        while (next != null)
                        {
                            keys.Add(next.Value.Key);
                            next = next.Next;
                        }
                    }
                }
                return keys;
            }
            private set { }
        }

        public bool ContainsKey(K key)
        {
            var hash = HashKey(key);

            if (this.values[hash] == null)
            {
                return false;
            }

            var pairs = this.values[hash];
            return pairs.Any(pair => pair.Key.Equals(key));
        }

        private int HashKey(K key)
        {
            var hash = key.GetHashCode();
            hash %= this.Capacity;
            hash = Math.Abs(hash);

            return hash;
        }

        private void ResizeAndReaddValues()
        {
            var cachedValues = this.values;

            this.values = new LinkedList<KeyValuePair<K,V>>[2 * this.Capacity];

            this.Count = 0;
            foreach (var valueColelction in cachedValues)
            {
                if (valueColelction != null)
                {
                    foreach (var value in valueColelction)
                    {
                        this.Add(value.Key, value.Value);
                    }
                }
            }
        }

        public IEnumerator<KeyValuePair<K, V>> GetEnumerator()
        {
            foreach (var valueColelction in this.values)
            {
                if (valueColelction != null)
                {
                    foreach (var value in valueColelction)
                    {
                        yield return value;
                    }
                }
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
