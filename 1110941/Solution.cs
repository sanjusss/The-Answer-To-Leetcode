using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1110941
{
    public class Solution
    {
        public bool ValidMountainArray(int[] A)
        {
            if (A.Length < 3)
            {
                return false;
            }

            bool needGreater = true;
            int last = A[0];
            int length = A.Length - 1;

            for (int i = 1; i < length; i++)
            {
                if (A[i] == last)
                {
                    return false;
                }

                if (needGreater)
                {
                    if (A[i] < last)
                    {
                        needGreater = false;
                        if (i == 1)
                        {
                            return false;
                        }
                    }
                }
                else if (A[i] > last)
                {
                    return false;
                }

                last = A[i];
            }

            return A[length] < last;
        }
    }
}
