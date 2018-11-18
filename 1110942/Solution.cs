using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1110942
{
    public class Solution
    {
        public int[] DiStringMatch(string S)
        {
            int[] res = new int[S.Length + 1];
            res[S.Length] = 0;
            int I = -1;
            int D = 1;
            for (int i = S.Length - 1; i >= 0; --i)
            {
                if (S[i] == 'I')
                {
                    res[i] = I--;
                }
                else
                {
                    res[i] = D++;
                }
            }

            int min = res.Min();
            for (int i = 0; i < res.Length; i++)
            {
                res[i] -= min;
            }

            return res;
        }
    }
}
