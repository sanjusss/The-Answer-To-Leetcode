using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1160961
{
    public class Solution
    {
        public int RepeatedNTimes(int[] A)
        {
            HashSet<int> vs = new HashSet<int>();
            foreach (var i in A)
            {
                if (vs.Contains(i))
                {
                    return i;
                }
                else
                {
                    vs.Add(i);
                }
            }

            return 0;
        }
    }
}
