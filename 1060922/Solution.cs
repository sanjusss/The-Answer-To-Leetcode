using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1060922
{
    public class Solution
    {
        public int[] SortArrayByParityII(int[] A)
        {
            List<int> a0 = new List<int>();
            List<int> a1 = new List<int>();
            foreach (var i in A)
            {
                if (i % 2 == 0)
                {
                    a0.Add(i);
                }
                else
                {
                    a1.Add(i);
                }
            }

            int count = A.Length / 2;
            for (int i = 0; i < count; ++i)
            {
                A[i * 2] = a0[i];
                A[i * 2 + 1] = a1[i];
            }

            return A;
        }
    }
}
