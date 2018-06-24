using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0856
{
    public class Solution
    {
        public int ScoreOfParentheses(string S)
        {
            int result = 0;
            char last = ')';
            Stack<int> temps = new Stack<int>();
            foreach (var i in S)
            {
                if (i == '(')
                {
                    temps.Push(result);
                    result = 0;
                }
                else if (last == '(')
                {
                    result = result + temps.Pop() + 1;
                }
                else
                {
                    result = (result << 1) + temps.Pop();
                }

                last = i;
            }

            return result;
        }
    }
}
