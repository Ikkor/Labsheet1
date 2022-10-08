using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customStack
{
    public interface ICustomStack<T>
    {
        void Push(T _data);
        int Count();
        T Pop();

    }
}
