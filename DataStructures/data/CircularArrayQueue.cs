using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.data
{
    internal class CircularArrayQueue<T>
    {
        // implementation of queue using array
        private int _size { get; set; }
        private int front { get; set; }
        private int rear { get; set; }
        private T[] queueArr { get; set; }
        public int Count { get; set; }
        public CircularArrayQueue(int size)
        {
            _size = size;
            queueArr = new T[size];
            Count= 0;
            front = 0;
            rear = size -1;
        }
        public bool IsEmpty()
        {
            return Count == 0;
        }
        public bool IsFull()
        {
            return Count == _size;
        }
        // add element to queue
        public void Enqueue(T item)
        {
            if(IsFull())
            {
                throw new Exception("Can not add to a full queue");
            }
            rear = (rear+ 1) % _size;
            Count++;
            queueArr[rear] = item;
        }
        // remove element from queue and return it
        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new Exception("can not remove from an empty queue");
            }
            T item = queueArr[front];
            front = (front + 1) % _size;
            Count--;
            return item;
        }
        // get front and rear of queue

        public T GetFront()
        {
            if (IsEmpty())
            {
                throw new Exception("no items added yet");
            }
            return queueArr[front];
        }

        public T GetRear()
        {
            if (IsEmpty()) {
                throw new Exception("no items added yet");
            }
            return queueArr[rear];
        }

        // search for an element
        // note we won't use linq because the element removed will still be in the array
        // we want only the elemnts in queue

        // note w return the index
        public int QueueSearch(T item)
        {
            int pos = -1;
            for(var i = front; i != rear + 1; i = (i+1) % _size)
            {
                if (queueArr[i].Equals(item))
                {
                    pos = i;
                    break;
                }
            }
            return pos;
        }
    }
}
