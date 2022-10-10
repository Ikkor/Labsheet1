using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customStack
{
    public class CustomStackExtendedOP
    {

        public static void DisplayAllInternsNameAndId(CustomStack<IIntern> _stack)
        {
            while (_stack.Count() > 0)
            {
                Console.WriteLine(_stack.Pop().NameId);
            }
        }
    }
}
