using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.data
{
    internal class CustomLinkedList<T>
    {
        public int Length { get; set; }

        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }

        public CustomLinkedList()
        {
            Length= 0;
            Head = null;
            Tail = Head;
        }
        public bool IsEmpty()
        {
            return Length == 0;
        }
        public void InsertAtFirst(T item)
        {
            Node<T> newNode = new Node<T>();
            newNode.Item = item;
            if (IsEmpty())
            {
             AddFirstElement(newNode);
                
            }
            else
            {
                newNode.next = Head;
                Head= newNode;
                Length++;
            }
        }
        private void AddFirstElement(Node<T> newNode)
        {
            Head = newNode;
            Tail = newNode;
            newNode.next = null;
            Length++;
        }
        public void InsertAtLast(T item)
        {
            Node<T> newNode = new Node<T>();
            newNode.Item = item;
            if(IsEmpty())
            {
                AddFirstElement(newNode);
            }
            else
            {
                Tail.next = newNode;
                Tail = newNode;
                newNode.next = null;
                Length++;
            }
        }
        // inert at a certain position (index wise)
        public void InsertAtPosition(int position , T item)
        {
            if (position == 0) InsertAtFirst(item);
            else if (position == Length) InsertAtLast(item);
            else
            {
                Node<T> newNode = new Node<T>();
                newNode.Item = item;
                Node<T> current = Head;
                for(int i =1; i < position; i++)
                {
                    current = current.next;
                }
                newNode.next = current.next;
                current.next = newNode;
                Length++;
            }
        }
    }
}
