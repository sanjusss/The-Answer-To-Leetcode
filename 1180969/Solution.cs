using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1180969
{
    public class Solution
    {
        public IList<int> PancakeSort(int[] A)
        {
            return PancakeSort(new List<int>(A));
        }

        public List<int> PancakeSort(List<int> A)
        {
            List<int> res = new List<int>();
            if (A.Count == 0)
            {
                return res;
            }

            int maxIndex = A.IndexOf(A.Max());
            if (maxIndex != A.Count - 1)
            {
                if (maxIndex != 0)
                {
                    res.Add(maxIndex + 1);
                    A.Reverse(0, maxIndex + 1);
                }

                res.Add(A.Count);
                A.Reverse();
            }

            A.RemoveAt(A.Count - 1);
            res.AddRange(PancakeSort(A));
            return res;
        }
    }
}
