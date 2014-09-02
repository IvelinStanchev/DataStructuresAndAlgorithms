namespace _11_LinkedListImplementation
{
    public class LinkedItem<T>
    {
        public T Value { get; set; }
        public LinkedItem<T> Previous { get; set; }
        public LinkedItem<T> NextItem { get; set; }
    }

    public class LinkedList<T> : System.Collections.Generic.IEnumerable<T>
    {
        private LinkedItem<T> Head { get; set; }
        private LinkedItem<T> Tail { get; set; }
        public void AddLast(T value)
        {
            var newNode = new LinkedItem<T>()
            {
                Value = value
            };

            if (this.Head == null && this.Tail == null)
            {
                this.Head = newNode;
                this.Tail = newNode;
            }
            else
            {
                this.Tail.NextItem = newNode;
                newNode.Previous = this.Tail;
                this.Tail = newNode;
            }
        }

        public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            var node = this.Head;
            while (node != null)
            {
                yield return node.Value;
                node = node.NextItem;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
