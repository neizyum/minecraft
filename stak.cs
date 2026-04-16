using System;
using System.Collections.Generic;
using System.Text;

namespace blyaaaaaaaaaa
{
    internal class stak
    {
        public int[] items = new int[16];
        private int count = 0;
    
    public void push(int numb)
        {
            if (count == items.Length) { throw new Exception("overloaded stack");}
            items[count] = numb;
            count++;
        }
    public void pop()
        {
            if (count == 0) { throw new Exception("empty stack"); }
            items [count--] = 0;
        }
    public int peak()
        {
            return items [count - 1];
        }
    }
}
