using System;
using System.Collections.Generic;
using System.Text;


namespace QueueImplementation
{
    class Queue
    {
        private const int DefaultQueueSize = 10;
        private object[] data;
        private int head = 0, tail = 0;
        private int numElements = 0;

        


        public Queue()
        {
            this.data = new object[DefaultQueueSize];
        }

        public Queue(int size)
        {
            if (size > 0)
            {
                this.data = new object[size];
            }
            else
            {
                throw new ArgumentOutOfRangeException("size", " must be great than zero");
            }
        }

        public void Enqueue(object item)
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

        public object[] ReturnQueue()
        {
            return this.data;
        }

        public object DeQueue()
        {
            if (this.numElements == 0)
            {
                throw new Exception("Queue Empty");
            }

            object queueitem = this.data[this.tail];
            this.tail++;
            //this.tail %= this.tail % this.data.Length;
            this.numElements--;
            return queueitem;
        }
    }
}
