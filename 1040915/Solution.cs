using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1040915
{
    public class Solution
    {
        public int PartitionDisjoint(int[] A)
        {
            int length = A.Length;
            int leftMax = int.MinValue;
            int rightMin = int.MaxValue;
            int i = -1;
            int next = -1;
            int last = 0;
            do
            {
                i = next;
                rightMin = int.MaxValue;
                for (int j = next + 1; j < length; ++j)
                {
                    if (rightMin > A[j])
                    {
                        next = j;
                        rightMin = A[j];
                    }
                }

                if (i == -1)
                {
                    continue;
                }

                for (int j = last; j < i; ++j)
                {
                    leftMax = Math.Max(leftMax, A[j]);
                }

                last = i;
            } while (leftMax > rightMin || i == -1);

            return i + 1;
        }
    }
}
