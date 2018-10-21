using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1070926
{
    public class Solution
    {
        public int MinFlipsMonoIncr(string S)
        {
            int length = S.Length;
            int zero = 0;
            int one = 0;
            foreach (var i in S)
            {
                if (i == '0')
                {
                    ++zero;
                }
                else
                {
                    ++one;
                }
            }

            int min = Math.Min(zero, one);
            if (min == 0)
            {
                return 0;
            }

            int zl = 0;
            int ol = 0;
            foreach (var i in S)
            {
                if (i == '0')
                {
                    ++zl;
                }
                else
                {
                    ++ol;
                }

                int zr = zero - zl;
                int or = one - ol;

                min = Math.Min(min, ol + zr);
                if (min == 0)
                {
                    return 0;
                }
            }

            return min;
        }
    }
}
