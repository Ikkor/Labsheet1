using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace customStack
{
    public class CustomStack<T> where T : IIntern
    {
        static int maxElements = 10;
        private int _pointer = 0;
        private T[] _arr = new T[maxElements];

        public void Push(T data)
            => _arr[_pointer++] = data;

        public T Pop()
            => _arr[--_pointer];
        public int Count() 
            => _pointer;    
        
       



    }
}
