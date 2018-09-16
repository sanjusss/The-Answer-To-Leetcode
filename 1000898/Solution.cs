using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000898
{
    public class Solution
    {
        public int SubarrayBitwiseORs(int[] A)
        {
            HashSet<int> ret = new HashSet<int>();
            int length = A.Length;
            for (int i = 0; i < length; ++i)
            {
                int bit = 0;
                for (int j = i; j < length; ++j)
                {
                    bit |= A[j];
                    ret.Add(bit);
                }
            }

            return ret.Count;
        }
    }
}
