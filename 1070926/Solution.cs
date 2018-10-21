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
            int one = 0;
            int zero = 0;
            int lastZeroIndex = -1;
            char lastChar = '\0';

            int startOneLength = 0;
            int firstZeroLength = 0;
            int res = 0;
            for (int i = 0; i < length; ++i)
            {
                if (S[i] == '0')
                {
                    lastZeroIndex = i;
                    if (one > 0)
                    {
                        ++zero;
                    }
                }
                else
                {
                    ++one;
                    if (lastChar == '0' && firstZeroLength == 0)
                    {
                        firstZeroLength = zero;
                        if (startOneLength > 0 && firstZeroLength >= startOneLength)
                        {
                            res += startOneLength;
                            one = 1;
                            zero = 0;
                            lastZeroIndex = -1;
                            firstZeroLength = 0;
                        }
                    }

                    if (firstZeroLength == 0)
                    {
                        startOneLength = one;
                    }
                }

                lastChar = S[i];
            }

            if (lastZeroIndex >= zero)
            {
                one -= (length - 1 - lastZeroIndex);
            }

            return res + Math.Min(one, zero);
        }
    }
}
