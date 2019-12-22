using System;
using System.Collections.Generic;
using System.Text;

namespace CopyStack
{
    class Stack
    {
        private string[] _contain;
        private int _top;
        public Stack()
        {
            _top = _contain.Length;
        }
        public void pus(params string[] elements)
        {
            
            for (int i = 0; i <elements.Length; i++)
            {
                if (_top >= _contain.Length)
                {
                    Console.WriteLine("栈满了，挤不进去了");
                    break;
                }
                _contain[_top] = elements[i];
                _top++;
            }
        }

    }
}
