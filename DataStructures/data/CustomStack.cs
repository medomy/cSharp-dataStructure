using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.data
{
    internal class CustomStack<T>
    {
   
        private int _size { get; set; }
        private T[] _stackArr { get; set; }
        private int Top { get; set; }
        public CustomStack(int size)
        {
            _size = size;
            _stackArr = new T[size];
            Top = -1;
        }
        public void Push(T item)
        {
            if(Top >= _size)
            {
                throw new Exception("exceded specified size");
            }
            Top += 1;
            _stackArr[Top] = item;
        }
        public T Pop() {
            if(IsEmpty())
            {
                throw new Exception("can not pop an empty stack");
            }
             T item = _stackArr[Top];
            Top -= 1;
            return item;
        }

        public bool IsEmpty() {
            return Top < 0;
        }

        public T GetTop()
        {
            return _stackArr[Top];
        }
    }
}
