using System;
using System.Collections.Generic;
using System.Text;


namespace QueueImplementation
{
    class Queue<T>
    {
        private const int DefaultQueueSize = 10;
        private T[] data;
        private int head = 0, tail = 0;
        private int numElements = 0;

        


        public Queue()
        {
            this.data = new T[DefaultQueueSize];
        }

        public Queue(int size)
        {
            if (size > 0)
            {
                this.data = new T[size];
            }
            else
            {
                throw new ArgumentOutOfRangeException("size", " must be great than zero");
            }
        }

        public void Enqueue(T item)
        {
            if (this.numElements == data.Length)
            {
                throw new Exception("Queue full");
            }
            this.data[this.head] = item;
            this.head++;
            this.head = this.head % this.data.Length;
            this.numElements++;
        }

        public T[] ReturnQueue()
        {
            return this.data;
        }

        public T DeQueue()
        {
            if (this.numElements == 0)
            {
                throw new Exception("Queue Empty");
            }

            T queueitem = this.data[this.tail];
            this.tail++;
            //this.tail %= this.tail % this.data.Length;
            this.numElements--;
            return queueitem;
        }
    }
}
