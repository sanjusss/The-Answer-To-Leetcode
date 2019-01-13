using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1190976
{
    public class Solution
    {
        public int LargestPerimeter(int[] A)
        {
            Array.Sort(A);
            for (int i = A.Length - 1; i >= 2; --i)
            {
                if (A[i] < A[i - 1] + A[i - 2])
                {
                    return A[i] + A[i - 1] + A[i - 2];
                }
            }

            return 0;
        }
    }
}
