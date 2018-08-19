using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _980891
{
    public class Solution
    {
        private const long mod = 1000000007;

        public int SumSubseqWidths(int[] A)
        {
            int length = A.Length;
            if (length <= 1)
            {
                return 0;
            }

            Array.Sort(A);
            long sum = 0;
            for (int i = 0; i < length - 1; ++i)
            {
                for (int j = i + 1; j < length; ++j)
                {
                    long ret = (A[j] - A[i]) % mod;
                    if (ret == 0)
                    {
                        continue;
                    }

                    ret = (Pow2Mod(j - i - 1) * ret) % mod;
                    sum = (sum + ret) % mod;
                }
            }

            return (int)sum;
        }

        private long Pow2Mod(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else if (x == 1)
            {
                return 2;
            }

            long ret = Pow2Mod(x / 2);
            ret = (ret * ret) % mod;
            if (x % 2 == 1)
            {
                ret = (ret * 2) % mod;
            }

            return mod;
        }
    }
}
