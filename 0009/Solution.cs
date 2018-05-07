using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0009
{
    public class Solution
    {
        public int Reverse(int x)
        {
            long src = x;
            long des = 0;
            long divisor = 10;
            long bit;
            while (src != 0)
            {
                src = Math.DivRem(src, divisor, out bit);
                des = divisor * des + bit;
            }

            if (des > int.MaxValue || des < int.MinValue)
            {
                des = 0;
            }

            return Convert.ToInt32(des);
        }

        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }

            return x == Reverse(x);
        }
    }
}
