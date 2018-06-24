using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0858
{
    public class Solution
    {
        int GCD(int i, int j)
        {
            int r = i % j;
            return r == 0 ? j : GCD(j, r);
        }

        public int MirrorReflection(int p, int q)
        {
            int c = GCD(p, q);
            p = p / c;
            q = q / c;
            if (p % 2 == 0)
            {
                return 2;
            }
            else if (q % 2 == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
