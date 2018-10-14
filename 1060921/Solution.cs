using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1060921
{
    public class Solution
    {
        public int MinAddToMakeValid(string S)
        {
            int count = 0;
            int left = 0;
            foreach (var i in S)
            {
                if (i == '(')
                {
                    ++left;
                }
                else if (i == ')')
                {
                    if (left == 0)
                    {
                        ++count;
                    }
                    else
                    {
                        --left;
                    }
                }
            }

            return count + left;
        }
    }
}
