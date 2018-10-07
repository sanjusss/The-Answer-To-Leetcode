using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1030908
{
    public class Solution
    {
        public int SmallestRangeI(int[] A, int K)
        {
            int max = A.Max();
            int min = A.Min();
            int ret = max - min - 2 * K;
            if (ret < 0)
            {
                ret = 0;
            }

            return ret;
        }
    }
}
