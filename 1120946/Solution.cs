using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1120946
{
    public class Solution
    {
        public bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            Stack<int> s = new Stack<int>();
            Queue<int> p = new Queue<int>(popped);
            foreach (var i in pushed)
            {
                s.Push(i);
                while (s.Count > 0 && s.Peek() == p.Peek())
                {
                    s.Pop();
                    p.Dequeue();
                }
            }

            return s.Count == 0;
        }
    }
}
