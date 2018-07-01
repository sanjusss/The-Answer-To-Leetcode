using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0862
{
    public class Solution
    {
        public int ShortestSubarray(int[] A, int K)
        {
            int ret = -1;
            int length = A.Length;
            for (int i = 0; i < length; ++i)
            {
                if (A[i] < 0)
                {
                    if (A[i] >= K)
                    {
                        ret = 1;
                    }

                    continue;
                }

                int maxCount = ret == -1 ? length : ret - 1;
                if (i + maxCount > length)
                {
                    maxCount = length - i;
                }

                int sum = 0;
                for (int j = 0; j < maxCount; ++j)
                {
                    sum += A[i + j];
                    if (sum >= K)
                    {
                        ret = j + 1;
                        break;
                    }
                }
            }

            return ret;
        }
    }
}
