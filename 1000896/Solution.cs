using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000896
{
    public class Solution
    {
        public bool IsMonotonic(int[] A)
        {
            int length = A.Length;
            int sign = 0;
            for (int i = 1; i < length; i++)
            {
                if (A[i] == A[i - 1])
                {
                    continue;
                }

                if (A[i] > A[i - 1])
                {
                    if (sign < 0)
                    {
                        return false;
                    }
                    else
                    {
                        sign = 1;
                    }
                }
                else
                {
                    if (sign > 0)
                    {
                        return false;
                    }
                    else
                    {
                        sign = -1;
                    }
                }
            }

            return true;
        }
    }
}
