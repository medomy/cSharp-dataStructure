using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.data
{
    internal class LinkedQueue<T>
    {
        public int Length { get; set; }

        private Node<T>? frontNode { get; set; }
        private Node<T>? backNode { get; set; }

        public LinkedQueue()
        {
            Length= 0;
            frontNode = new Node<T>();
            backNode = new Node<T>();
        }

        public bool IsEmpty()
        {
            return Length == 0;
        }
        public void Enqueue(T item)
        {
            Node<T> newNode = new Node<T>();
            newNode.Item = item;
            newNode.next = null;
            if(IsEmpty())
            {
                //frontNode.Item = newNode.Item;
                //backNode.Item = newNode.Item;
                //frontNode.next = backNode.next = newNode.next;
                frontNode = newNode;
                backNode = newNode;
                Length++;
            }
            else {
                if (Length == 1) frontNode.next = newNode;
                backNode.next = newNode;
                //backNode.Item = newNode.Item;
                //backNode.next = newNode.next;
                backNode = newNode;
                Length++;
            }

        }
        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new Exception("can not dequeue an empty queue");
            }
            Node<T> poppedVal = frontNode;
            frontNode = frontNode!.next;
            Length--;
            if (IsEmpty())
            {
                backNode = null;
            }
            return poppedVal.Item;
        }

    }
}
