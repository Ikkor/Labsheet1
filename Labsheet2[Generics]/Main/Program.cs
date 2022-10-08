using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using customStack;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new CustomStack<Jedi>();
            stack.Push(new Jedi("navin", 3));
            stack.Push(new Jedi("pravin", 2));
            stack.Push(new Jedi("arvin", 1));



            CustomStackExtendedOP.DisplayAllInternsNameAndId(stack);

            Console.ReadKey();
        }
    }
}
