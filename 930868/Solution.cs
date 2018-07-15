using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _930868
{
    public class Solution
    {
        public int BinaryGap(int N)
        {
            int length = (int)Math.Ceiling(Math.Log(N, 2));//bit
            int ret = 0;
            int lastPos = -1;
            for (int i = 0; i < length; i++)
            {
                if (N % 2 == 1)
                {
                    if (lastPos != -1)
                    {
                        ret = Math.Max(i - lastPos, ret);
                    }

                    lastPos = i;
                }

                N /= 2;
            }

            return ret;
        }
    }
}
