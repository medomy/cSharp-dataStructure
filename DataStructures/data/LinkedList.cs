using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.data
{
    class Node<T>
    {
        public T Item { get; set; }
        public Node<T>? next { get; set; }
    }
    internal class LinkedListStack<T>
    {
        public int Length { get; set; }

        public Node<T>? Top { get; set; }

        public LinkedListStack()
        {
            Length= 0;
            Top = null;
        }

        public bool IsEmpty ()
        {
            return Length == 0;
        }
        public void Push(T item)
        {
            Node<T> node = new Node<T>();
            node.Item = item;
            node.next = Top;
            Top = node;
            Length++;
        }
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("cannot pop of an empty stack");
            }
            Node<T>? temp = Top;
            Top = Top!.next;
            Length--;
            return temp!.Item;
        }

        public T  GetTop()
        {
            if(IsEmpty())
            {
                throw new Exception("Cannot get the top of an empty stack");
            }
            return Top!.Item;
        }
    }
}