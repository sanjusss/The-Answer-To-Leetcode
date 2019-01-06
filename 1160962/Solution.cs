using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1160962
{
    public class Solution
    {
        public int MaxWidthRamp(int[] A)
        {
            int res = 0;
            int min = int.MaxValue;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < min)
                {
                    min = A[i];
                    continue;
                }

                int searchLength = i - res;
                for (int j = 0; j < searchLength; j++)
                {
                    if (A[i] >= A[j])
                    {
                        res = i - j;
                        break;
                    }
                }
            }

            return res;
        }
    }
}
