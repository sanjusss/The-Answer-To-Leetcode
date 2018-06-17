using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0852
{
    public class Solution
    {
        public int PeakIndexInMountainArray(int[] A)
        {
            int max = A.Length - 1;
            int l = 0;
            int r = max;
            int m = 0;
            while (l < r)
            {
                m = (l + r) >> 1;
                if (m > 0 && A[m] < A[m - 1])
                {
                    r = m;
                }
                else if (m < max && A[m] < A[m + 1])
                {
                    l = m;
                }
                else
                {
                    return m;
                }
            }

            return m;
        }
    }
}
