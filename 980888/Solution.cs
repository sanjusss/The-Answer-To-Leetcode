using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _980888
{
    public class Solution
    {
        public int[] FairCandySwap(int[] A, int[] B)
        {
            int sumA = A.Sum();
            int sumB = B.Sum();
            int diff = (sumB - sumA) / 2;
            HashSet<int> ca = new HashSet<int>(A);
            HashSet<int> cb = new HashSet<int>(B);
            foreach (var i in ca)
            {
                if (cb.Contains(i + diff))
                {
                    return new int[] { i, i + diff };
                }
            }

            return null;
        }
    }
}
