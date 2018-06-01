using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0168
{
    public class Solution
    {
        public string ConvertToTitle(int n)
        {
            string res = string.Empty;
            while (n > 0)
            {
                int remain;
                n = Math.DivRem(n, 26, out remain);
                if (remain == 0)
                {
                    remain = 26;
                    --n;
                }

                res = Convert.ToChar('A' - 1 + remain) + res;
            }

            return res;
        }
    }
}
