using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1120945
{
    public class Solution
    {
        public int MinIncrementForUnique(int[] A)
        {
            Array.Sort(A);
            int r = 0;
            int remains = 0;
            int last = -1;
            foreach (var i in A)
            {
                if (i == last)
                {
                    ++remains;
                }
                else
                {
                    int step = i - last;
                    if (step > 1)
                    {
                        int u = Math.Min(step - 1, remains);
                        remains -= u;
                        r += (u + 1) * u / 2;
                    }

                    r += remains * step;
                }

                last = i;
            }

            r += (remains + 1) * remains / 2;
            return r;
        }
    }
}
