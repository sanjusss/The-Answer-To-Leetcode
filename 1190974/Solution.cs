using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1190974
{
    public class Solution
    {
        public int SubarraysDivByK(int[] A, int K)
        {
            Dictionary<int, int> ans = new Dictionary<int, int>();
            int s = 0;
            ans[0] = 1;
            foreach (var i in A)
            {
                s += i;
                s = s % K;
                if (s < 0)
                {
                    s += K;
                }
                
                ans[s] = ans.ContainsKey(s) ? ans[s] + 1 : 1;
            }

            int count = 0;
            foreach (var i in ans)
            {
                count += i.Value * (i.Value - 1) / 2;
            }

            return count;
        }
    }
}
