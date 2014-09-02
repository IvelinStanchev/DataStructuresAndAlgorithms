using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_DynamicQueue
{
    class LinkedQueue<T>
    {
        LinkedQueueNode<T> firstItem;
        LinkedQueueNode<T> lastItem;
        int count;

        public void Push(T value)
        {
            if (firstItem == null)
            {
                lastItem = new LinkedQueueNode<T>(value);
                firstItem = lastItem;
            }
            else
            {
                lastItem.PreviousItem = new LinkedQueueNode<T>(value);
                lastItem = lastItem.PreviousItem;
            }

            count++;
        }

        public T Peek()
        {
            return firstItem.Value;
        }

        public T Pop()
        {
            if (firstItem == null)
            {
                throw new InvalidOperationException("Queue is empty.");
            }
            T valueToReturn = firstItem.Value;
            firstItem = firstItem.PreviousItem;
            count--;

            return valueToReturn;
        }

        public int Count
        {
            get
            {
                return count;
            }
        }
    }

    class LinkedQueueNode<T>
    {
        T value;
        LinkedQueueNode<T> previousItem;

        public LinkedQueueNode()
        {
        }

        public LinkedQueueNode(T value)
        {
            this.Value = value;
        }

        public T Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }

        public LinkedQueueNode<T> PreviousItem
        {
            get
            {
                return this.previousItem;
            }
            set
            {
                this.previousItem = value;
            }
        }
    }
}
