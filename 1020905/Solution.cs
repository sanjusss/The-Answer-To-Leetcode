using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1020905
{
    class Solution
    {
        public int[] SortArrayByParity(int[] A)
        {
            int[] ret = new int[A.Length];
            int start = 0;
            int end = A.Length - 1;
            foreach (var i in A)
            {
                if (i % 2 == 0)
                {
                    ret[start++] = i;
                }
                else
                {
                    ret[end--] = i;
                }
            }

            return ret;
        }
    }
}
